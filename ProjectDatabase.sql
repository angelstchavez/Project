CREATE DATABASE ProjectDatabase;
GO

USE ProjectDatabase;
GO

-- Tables
CREATE TABLE Roles
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(20) NOT NULL
);

CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(20) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    IsActive BIT NOT NULL,
    CreatedAt DATETIME NOT NULL,
    RoleId INT FOREIGN KEY REFERENCES Roles(Id)
);


CREATE TABLE Modules
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    RoleId INT FOREIGN KEY REFERENCES Roles(Id)
);
GO

CREATE TABLE Expenditures
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Date DATETIME NOT NULL,
    Category NVARCHAR(MAX) NOT NULL,
    Description NVARCHAR(MAX),
    Value DECIMAL(18,2) NOT NULL,
    CreatedAt DATETIME NOT NULL
);
GO

-- Procedures

CREATE PROCEDURE CreateUser
    @Username NVARCHAR(255),
    @Password NVARCHAR(255),
    @IsActive BIT,
    @RoleId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = @Username)
    BEGIN
        INSERT INTO Users (Username, Password, IsActive, CreatedAt, RoleId)
        VALUES (@Username, @Password, @IsActive, GETDATE(), @RoleId);
        SELECT SCOPE_IDENTITY() AS UserId;
    END
    ELSE
    BEGIN
        RAISERROR('Ya existe un usuario con este nombre.', 16, 1);
    END
END;
GO

CREATE PROCEDURE GetUser
    @UserId INT
AS
BEGIN
    SELECT * FROM Users WHERE Id = @UserId;
END;
GO

CREATE PROCEDURE UpdateUser
    @UserId INT,
    @Username NVARCHAR(255),
    @Password NVARCHAR(255),
    @IsActive BIT,
    @RoleId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Users WHERE Id = @UserId)
    BEGIN
        RAISERROR('Usuario no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        UPDATE Users
        SET Username = @Username,
            Password = @Password,
            IsActive = @IsActive,
            RoleId = @RoleId
        WHERE Id = @UserId;
    END
END;
GO

CREATE PROCEDURE DeleteUser
    @UserId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Users WHERE Id = @UserId)
    BEGIN
        RAISERROR('Usuario no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        DELETE FROM Users WHERE Id = @UserId;
    END
END;
GO

CREATE PROCEDURE GetAllUsers
AS
BEGIN
    SELECT * FROM Users;
END;
GO

CREATE PROCEDURE CreateModule
    @ModuleName NVARCHAR(255),
    @RoleId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Modules WHERE Name = @ModuleName)
    BEGIN
        INSERT INTO Modules (Name, RoleId)
        VALUES (@ModuleName, @RoleId);
        SELECT SCOPE_IDENTITY() AS ModuleId;
    END
    ELSE
    BEGIN
        -- Module name already exists, handle accordingly (e.g., raise an error)
        RAISERROR('El modulo con este nombre ya existe.', 16, 1);
    END
END;
GO

CREATE PROCEDURE GetModule
    @ModuleId INT
AS
BEGIN
    SELECT * FROM Modules WHERE Id = @ModuleId;
END;
GO

CREATE PROCEDURE UpdateModule
    @ModuleId INT,
    @ModuleName NVARCHAR(255),
    @RoleId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Modules WHERE Id = @ModuleId)
    BEGIN
        RAISERROR('Modulo no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        UPDATE Modules
        SET Name = @ModuleName,
            RoleId = @RoleId
        WHERE Id = @ModuleId;
    END
END;
GO

CREATE PROCEDURE DeleteModule
    @ModuleId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Modules WHERE Id = @ModuleId)
    BEGIN
        RAISERROR('Modulo no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        DELETE FROM Modules WHERE Id = @ModuleId;
    END
END;
GO

CREATE PROCEDURE GetModulesByUserId
    @UserId INT
AS
BEGIN
    SELECT M.*
    FROM Modules M
    INNER JOIN Roles R ON M.RoleId = R.Id
    INNER JOIN Users U ON R.Id = U.RoleId
    WHERE U.Id = @UserId;
END;
GO

CREATE PROCEDURE CreateExpenditure
    @Date DATETIME,
    @Category NVARCHAR(MAX),
    @Description NVARCHAR(MAX),
    @Value DECIMAL(18,2),
    @CreatedAt DATETIME
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Expenditures WHERE Date = @Date AND Category = @Category)
    BEGIN
        INSERT INTO Expenditures (Date, Category, Description, Value, CreatedAt)
        VALUES (@Date, @Category, @Description, @Value, @CreatedAt);
        SELECT SCOPE_IDENTITY() AS ExpenditureId;
    END
    ELSE
    BEGIN
        RAISERROR('Ya existe un gasto con esta fecha y categoría.', 16, 1);
    END
END;
GO

CREATE PROCEDURE GetExpenditure
    @ExpenditureId INT
AS
BEGIN
    SELECT * FROM Expenditures WHERE Id = @ExpenditureId;
END;
GO

CREATE PROCEDURE UpdateExpenditure
    @ExpenditureId INT,
    @Date DATETIME,
    @Category NVARCHAR(MAX),
    @Description NVARCHAR(MAX),
    @Value DECIMAL(18,2),
    @CreatedAt DATETIME
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Expenditures WHERE Id = @ExpenditureId)
    BEGIN
        RAISERROR('Gasto no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        UPDATE Expenditures
        SET Date = @Date,
            Category = @Category,
            Description = @Description,
            Value = @Value,
            CreatedAt = @CreatedAt
        WHERE Id = @ExpenditureId;
    END
END;
GO

CREATE PROCEDURE DeleteExpenditure
    @ExpenditureId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Expenditures WHERE Id = @ExpenditureId)
    BEGIN
        RAISERROR('Gasto no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        DELETE FROM Expenditures WHERE Id = @ExpenditureId;
    END
END;
GO

CREATE PROCEDURE GetAllExpenditures
AS
BEGIN
    SELECT * FROM Expenditures;
END;
GO

CREATE PROCEDURE GetExpendituresBySpecificDate
    @SpecificDate DATETIME
AS
BEGIN
    SELECT * FROM Expenditures WHERE Date = @SpecificDate;
END;
GO

CREATE PROCEDURE GetTotalExpensesPerDay
AS
BEGIN
    SELECT
        CONVERT(DATE, Date) AS Date,
        SUM(Value) AS TotalExpenses
    FROM Expenditures
    GROUP BY CONVERT(DATE, Date);
END;
GO

CREATE PROCEDURE GetAllExpensesByDate
    @SpecificDate DATETIME
AS
BEGIN
    SELECT * FROM Expenditures WHERE CONVERT(DATE, Date) = CONVERT(DATE, @SpecificDate);
END;
GO