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
