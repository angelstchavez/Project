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

CREATE TABLE ProductCategory
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    IsActive BIT NOT NULL
);
GO

CREATE TABLE Product
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    CategoryId INT FOREIGN KEY REFERENCES ProductCategory(Id),
    IsActive BIT NOT NULL
);
GO

CREATE TABLE Customer (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(255) NOT NULL,
    Phone NVARCHAR(20),
    CreatedAt DATETIME
);
GO

CREATE TABLE Neighborhood
(
    Id INT PRIMARY KEY IDENTITY (1,1),
    Name NVARCHAR(255) NULL,
    CommuneNumber NVARCHAR(10) NULL
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

CREATE PROCEDURE CreateProductCategory
    @Name NVARCHAR(255),
    @IsActive BIT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM ProductCategory WHERE Name = @Name)
    BEGIN
        RAISERROR('Ya existe una categoría de producto con el mismo nombre.', 16, 1)
        RETURN
    END

    INSERT INTO ProductCategory (Name, IsActive)
    VALUES (@Name, @IsActive)
END;
GO

CREATE PROCEDURE UpdateProductCategory
    @Id INT,
    @Name NVARCHAR(255),
    @IsActive BIT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM ProductCategory WHERE Id = @Id)
    BEGIN
        RAISERROR('Categoría de producto no encontrada.', 16, 1)
        RETURN
    END

    UPDATE ProductCategory
    SET Name = @Name,
        IsActive = @IsActive
    WHERE Id = @Id
END;
GO

CREATE PROCEDURE GetAllActiveProductCategory
AS
BEGIN
    SELECT *
    FROM ProductCategory
    WHERE IsActive = 1
END;
GO

CREATE PROCEDURE GetProductCategory
    @Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM ProductCategory WHERE Id = @Id)
    BEGIN
        RAISERROR('Categoría de producto no encontrada.', 16, 1)
        RETURN
    END

    SELECT *
    FROM ProductCategory
    WHERE Id = @Id
END;
GO

CREATE PROCEDURE DeleteProductCategory
    @Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM ProductCategory WHERE Id = @Id)
    BEGIN
        RAISERROR('Categoría de producto no encontrada.', 16, 1)
        RETURN
    END

    DELETE FROM ProductCategory
    WHERE Id = @Id
END;
GO

CREATE PROCEDURE CreateProduct
    @Name NVARCHAR(255),
    @Price DECIMAL(18, 2),
    @CategoryId INT,
    @IsActive BIT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Product WHERE Name = @Name)
    BEGIN
        RAISERROR('Ya existe un producto con el mismo nombre.', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT 1 FROM ProductCategory WHERE Id = @CategoryId)
    BEGIN
        RAISERROR('ID de categoría de producto no válido.', 16, 1)
        RETURN
    END

    INSERT INTO Product (Name, Price, CategoryId, IsActive)
    VALUES (@Name, @Price, @CategoryId, @IsActive)
END;
GO

CREATE PROCEDURE UpdateProduct
    @Id INT,
    @Name NVARCHAR(255),
    @Price DECIMAL(18, 2),
    @CategoryId INT,
    @IsActive BIT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Product WHERE Id = @Id)
    BEGIN
        RAISERROR('Producto no encontrado.', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT 1 FROM ProductCategory WHERE Id = @CategoryId)
    BEGIN
        RAISERROR('ID de categoría de producto no válido.', 16, 1)
        RETURN
    END

    UPDATE Product
    SET Name = @Name,
        Price = @Price,
        CategoryId = @CategoryId,
        IsActive = @IsActive
    WHERE Id = @Id
END;
GO

CREATE PROCEDURE GetAllProductsWithCategory
AS
BEGIN
    SELECT
        P.Id AS ProductId,
        P.Name AS ProductName,
        P.Price,
        PC.Name AS CategoryName,
        P.IsActive AS ProductIsActive
    FROM
        Product AS P
    INNER JOIN
        ProductCategory AS PC ON P.CategoryId = PC.Id
		    WHERE
        P.IsActive = 1;
END;
GO

CREATE PROCEDURE GetAllActiveProducts
AS
BEGIN
    SELECT *
    FROM Product
    WHERE IsActive = 1
END;
GO

CREATE PROCEDURE GetProduct
    @Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Product WHERE Id = @Id)
    BEGIN
        RAISERROR('Producto no encontrado.', 16, 1)
        RETURN
    END

    SELECT *
    FROM Product
    WHERE Id = @Id
END;
GO

CREATE PROCEDURE DeleteProduct
    @Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Product WHERE Id = @Id)
    BEGIN
        RAISERROR('Producto no encontrado.', 16, 1)
        RETURN
    END

    DELETE FROM Product
    WHERE Id = @Id
END;
GO

CREATE PROCEDURE GetActiveProductsByCategoryId
    @CategoryId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM ProductCategory WHERE Id = @CategoryId)
    BEGIN
        RAISERROR('ID de categoría de producto no válido.', 16, 1)
        RETURN
    END

    SELECT P.*
    FROM Product P
    WHERE P.IsActive = 1 AND P.CategoryId = @CategoryId
END;
GO

CREATE PROCEDURE CreateCustomer
    @Name NVARCHAR(255),
    @Phone NVARCHAR(20),
    @CreatedAt DATETIME
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE Name = @Name)
    BEGIN
        INSERT INTO Customer (Name, Phone, CreatedAt)
        VALUES (@Name, @Phone, @CreatedAt);
        SELECT SCOPE_IDENTITY() AS CustomerId;
    END
    ELSE
    BEGIN
        RAISERROR('Ya existe un cliente con este nombre.', 16, 1);
    END
END;
GO

CREATE PROCEDURE GetCustomer
    @CustomerId INT
AS
BEGIN
    SELECT * FROM Customer WHERE Id = @CustomerId;
END;
GO

CREATE PROCEDURE UpdateCustomer
    @CustomerId INT,
    @Name NVARCHAR(255),
    @Phone NVARCHAR(20),
    @CreatedAt DATETIME
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE Id = @CustomerId)
    BEGIN
        RAISERROR('Cliente no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        UPDATE Customer
        SET Name = @Name,
            Phone = @Phone,
            CreatedAt = @CreatedAt
        WHERE Id = @CustomerId;
    END
END;
GO

CREATE PROCEDURE DeleteCustomer
    @CustomerId INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE Id = @CustomerId)
    BEGIN
        RAISERROR('Cliente no encontrado.', 16, 1);
    END
    ELSE
    BEGIN
        DELETE FROM Customer WHERE Id = @CustomerId;
    END
END;
GO

CREATE PROCEDURE GetAllCustomers
AS
BEGIN
    SELECT * FROM Customer;
END;
GO

CREATE PROCEDURE GetPagedCustomers
    @PageSize INT,
    @PageNumber INT
AS
BEGIN
    DECLARE @Offset INT = (@PageNumber - 1) * @PageSize;

    SELECT *
    FROM (
        SELECT 
            ROW_NUMBER() OVER (ORDER BY Id) AS RowNum,
            *
        FROM Customer
    ) AS CustomersWithRowNumber
    WHERE RowNum > @Offset AND RowNum <= (@Offset + @PageSize);
END;
GO

CREATE PROCEDURE GetTotalCustomerCount
AS
BEGIN
    SELECT COUNT(*) FROM Customer;
END;
GO

CREATE PROCEDURE GetDistinctCommunes
AS
BEGIN
    SELECT DISTINCT CommuneNumber
    FROM Neighborhood
    WHERE CommuneNumber IS NOT NULL;
END;
GO

CREATE PROCEDURE GetNeighborhoodsByCommune
    @CommuneNumber NVARCHAR(10)
AS
BEGIN
    SELECT Name
    FROM Neighborhood
    WHERE CommuneNumber = @CommuneNumber;
END;
GO

CREATE PROCEDURE GetTotalExpenditureByCategory
AS
BEGIN
    SELECT Category, SUM(Value) AS TotalExpenditure
    FROM Expenditures
    GROUP BY Category;
END;
GO

CREATE PROCEDURE GetExpenditureByMonth
    @Month INT,
    @Year INT
AS
BEGIN
    DECLARE @StartDate DATETIME, @EndDate DATETIME;

    SET @StartDate = DATEFROMPARTS(@Year, @Month, 1);
    SET @EndDate = EOMONTH(@StartDate);

    SELECT *
    FROM Expenditures
    WHERE Date >= @StartDate AND Date <= @EndDate;
END;
GO

CREATE PROCEDURE GetMonthlyExpenditureByCategory
    @Month INT,
    @Year INT
AS
BEGIN
    DECLARE @StartDate DATETIME;
    DECLARE @EndDate DATETIME;

    SET @StartDate = DATEADD(MONTH, @Month - 1, DATEADD(YEAR, @Year - 1900, 0));
    SET @EndDate = DATEADD(MONTH, 1, @StartDate);

    SELECT Category, SUM(Value) AS TotalExpenditure
    FROM Expenditures
    WHERE Date >= @StartDate AND Date < @EndDate
    GROUP BY Category;
END;
GO

CREATE PROCEDURE GetCustomerByPhoneNumber
    @PhoneNumber NVARCHAR(20)
AS
BEGIN
    SELECT * FROM Customer WHERE Phone = @PhoneNumber;
END;
GO