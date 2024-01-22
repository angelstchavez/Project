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

CREATE TABLE TransportationCompany
(
    Id INT PRIMARY KEY IDENTITY (1,1),
    Name NVARCHAR(255) NOT NULL,
    CreatedAt DATETIME NOT NULL
);
GO

CREATE TABLE Sale (
    Id INT PRIMARY KEY IDENTITY(1,1),
	UserId INT FOREIGN KEY REFERENCES [Users](Id),
    CustomerId INT FOREIGN KEY REFERENCES Customer(Id),
    TransportationCompanyId INT FOREIGN KEY REFERENCES TransportationCompany(Id),
    Address NVARCHAR(255),
    NeighborhoodId INT FOREIGN KEY REFERENCES Neighborhood(Id),
    PaymentType NVARCHAR(255),
    TotalAmount DECIMAL(18, 2),
    CreatedAt DATETIME
);
GO

CREATE TABLE SaleDetail (
    Id INT PRIMARY KEY IDENTITY(1,1),
    SaleId INT FOREIGN KEY REFERENCES Sale(Id),
    ProductId INT FOREIGN KEY REFERENCES Product(Id),
    Amount DECIMAL(18, 2),
    Quantity INT,
    CreatetAt DATETIME
);
GO

CREATE TABLE PrintingArea (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255),
    CreatetAt DATETIME
);
GO

CREATE TABLE Printer (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255),
    AreaId INT,
    CreatetAt DATETIME,
    FOREIGN KEY (AreaId) REFERENCES PrintingArea(Id)
);
GO

CREATE TABLE CashRegister
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    IsActive BIT NOT NULL,
    CreatedAt DATETIME NOT NULL
);
GO

CREATE TABLE CashMovement
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    CashRegisterId INT FOREIGN KEY REFERENCES CashRegister(Id),
    SaleId INT FOREIGN KEY REFERENCES Sale(Id),
    ExpenditureId INT FOREIGN KEY REFERENCES Expenditures(Id),
    Amount DECIMAL(18, 2) NOT NULL,
    MovementType NVARCHAR(20) NOT NULL,
    CreatedAt DATETIME NOT NULL
);
GO

CREATE TABLE SaleMovements
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    SaleId INT FOREIGN KEY REFERENCES Sale(Id),
    Amount DECIMAL(18, 2) NOT NULL,
    CreatedAt DATETIME NOT NULL
);
GO

CREATE TABLE ExpenseMovements
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    ExpenditureId INT FOREIGN KEY REFERENCES Expenditures(Id),
    Amount DECIMAL(18, 2) NOT NULL,
    CreatedAt DATETIME NOT NULL
);
GO

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
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE Phone = @Phone)
    BEGIN
        INSERT INTO Customer (Name, Phone, CreatedAt)
        VALUES (@Name, @Phone, @CreatedAt);
        SELECT SCOPE_IDENTITY() AS CustomerId;
    END
    ELSE
    BEGIN
        RAISERROR('Ya existe un cliente con este número de teléfono.', 16, 1);
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
    SELECT Id, Name
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

-- Procedimiento almacenado para la creación de una venta
CREATE PROCEDURE CreateSale
    @UserId INT,
    @CustomerId INT,
    @Address NVARCHAR(255),
    @NeighborhoodId INT,
    @TransportationCompanyId INT,
    @PaymentType NVARCHAR(255),
    @TotalAmount DECIMAL(18, 2),
    @CreatedAt DATETIME,
    @SaleId INT OUTPUT -- Agrega un parámetro de salida para el ID de la venta
AS
BEGIN
    -- Validar que el usuario exista
    IF NOT EXISTS (SELECT 1 FROM [Users] WHERE Id = @UserId)
    BEGIN
        RAISERROR('El usuario no existe.', 16, 1);
        RETURN;
    END

    -- Validar que el cliente exista
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE Id = @CustomerId)
    BEGIN
        RAISERROR('El cliente no existe.', 16, 2);
        RETURN;
    END

    -- Validar que el barrio exista
    IF NOT EXISTS (SELECT 1 FROM Neighborhood WHERE Id = @NeighborhoodId)
    BEGIN
        RAISERROR('El barrio no existe.', 16, 3);
        RETURN;
    END

    -- Validar otras condiciones según sea necesario

    -- Insertar la venta
    INSERT INTO Sale (UserId, CustomerId, Address, NeighborhoodId, TransportationCompanyId,  PaymentType, TotalAmount, CreatedAt)
    VALUES (@UserId, @CustomerId, @Address, @NeighborhoodId, @TransportationCompanyId, @PaymentType, @TotalAmount, @CreatedAt);

    -- Obtener el ID generado
    SET @SaleId = SCOPE_IDENTITY();
END;
GO

-- Procedimiento almacenado para la eliminación de una venta
CREATE PROCEDURE DeleteSale
    @SaleId INT
AS
BEGIN
    -- Validar que la venta exista
    IF NOT EXISTS (SELECT 1 FROM Sale WHERE Id = @SaleId)
    BEGIN
        RAISERROR('La venta no existe.', 16, 4);
        RETURN;
    END

    -- Otras validaciones según sea necesario

    -- Eliminar la venta
    DELETE FROM Sale WHERE Id = @SaleId;
END;
GO

-- Procedimiento almacenado para obtener una venta por su Id
CREATE PROCEDURE GetSale
    @SaleId INT
AS
BEGIN
    -- Obtener la venta por su Id
    SELECT *
    FROM Sale
    WHERE Id = @SaleId;
END;
GO

-- Procedimiento almacenado para obtener todas las ventas
CREATE PROCEDURE GetAllSales
AS
BEGIN
    -- Obtener todas las ventas
    SELECT *
    FROM Sale;
END;
GO

-- Procedimiento almacenado para actualizar una venta
CREATE PROCEDURE UpdateSale
    @SaleId INT,
    @UserId INT,
    @CustomerId INT,
    @Address NVARCHAR(255),
    @NeighborhoodId INT,
    @PaymentType NVARCHAR(255),
    @TotalAmount DECIMAL(18, 2),
    @CreatedAt DATETIME
AS
BEGIN
    -- Validar que la venta exista
    IF NOT EXISTS (SELECT 1 FROM Sale WHERE Id = @SaleId)
    BEGIN
        RAISERROR('La venta no existe.', 16, 5);
        RETURN;
    END

    -- Validar que el usuario exista
    IF NOT EXISTS (SELECT 1 FROM [Users] WHERE Id = @UserId)
    BEGIN
        RAISERROR('El usuario no existe.', 16, 6);
        RETURN;
    END

    -- Validar que el cliente exista
    IF NOT EXISTS (SELECT 1 FROM Customer WHERE Id = @CustomerId)
    BEGIN
        RAISERROR('El cliente no existe.', 16, 7);
        RETURN;
    END

    -- Validar que el barrio exista
    IF NOT EXISTS (SELECT 1 FROM Neighborhood WHERE Id = @NeighborhoodId)
    BEGIN
        RAISERROR('El barrio no existe.', 16, 8);
        RETURN;
    END

    -- Validar otras condiciones según sea necesario

    -- Actualizar la venta
    UPDATE Sale
    SET UserId = @UserId,
        CustomerId = @CustomerId,
        Address = @Address,
        NeighborhoodId = @NeighborhoodId,
        PaymentType = @PaymentType,
        TotalAmount = @TotalAmount,
        CreatedAt = @CreatedAt
    WHERE Id = @SaleId;
END;
GO

-- Create SaleDetail
CREATE PROCEDURE CreateSaleDetail
    @SaleId INT,
    @ProductId INT,
    @Amount DECIMAL(18, 2),
    @Quantity INT,
    @CreatetAt DATETIME
AS
BEGIN
    -- Validation: Add your custom validation logic here
    IF @Quantity <= 0
    BEGIN
        RAISERROR('La cantidad debe ser superior a cero.', 16, 1);
        RETURN;
    END

    INSERT INTO SaleDetail (SaleId, ProductId, Amount, Quantity, CreatetAt)
    VALUES (@SaleId, @ProductId, @Amount, @Quantity, @CreatetAt);
END
GO

-- Update SaleDetail
CREATE PROCEDURE UpdateSaleDetail
    @Id INT,
    @SaleId INT,
    @ProductId INT,
    @Amount DECIMAL(18, 2),
    @Quantity INT,
    @CreatetAt DATETIME
AS
BEGIN
    -- Validation: Add your custom validation logic here
    IF @Quantity <= 0
    BEGIN
        RAISERROR('La cantidad debe ser superior a cero.', 16, 1);
        RETURN;
    END

    UPDATE SaleDetail
    SET SaleId = @SaleId, ProductId = @ProductId, Amount = @Amount, Quantity = @Quantity, CreatetAt = @CreatetAt
    WHERE Id = @Id;
END
GO

-- Get SaleDetail by Id
CREATE PROCEDURE sp_GetSaleDetail
    @Id INT
AS
BEGIN
    SELECT *
    FROM SaleDetail
    WHERE Id = @Id;
END
GO

-- Delete SaleDetail
CREATE PROCEDURE DeleteSaleDetail
    @Id INT
AS
BEGIN
    DELETE FROM SaleDetail
    WHERE Id = @Id;
END
GO

-- Get all SaleDetails
CREATE PROCEDURE GetAllSaleDetails
AS
BEGIN
    SELECT *
    FROM SaleDetail;
END
GO

CREATE PROCEDURE CreateTransportationCompany
    @Name NVARCHAR(255),
    @CreatedAt DATETIME
AS
BEGIN
    INSERT INTO TransportationCompany (Name, CreatedAt)
    VALUES (@Name, @CreatedAt);
END;
GO

CREATE PROCEDURE UpdateTransportationCompany
    @Id INT,
    @Name NVARCHAR(255),
    @CreatedAt DATETIME
AS
BEGIN
    UPDATE TransportationCompany
    SET Name = @Name, CreatedAt = @CreatedAt
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE DeleteTransportationCompany
    @Id INT
AS
BEGIN
    DELETE FROM TransportationCompany
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE GetTransportationCompany
    @Id INT
AS
BEGIN
    SELECT * FROM TransportationCompany
    WHERE Id = @Id;
END;

GO

CREATE PROCEDURE GetAllTransportationCompanies
AS
BEGIN
    SELECT * FROM TransportationCompany;
END;
GO

CREATE PROCEDURE CreatePrinter
    @Name VARCHAR(255),
    @AreaId INT,
    @CreatetAt DATETIME
AS
BEGIN
    INSERT INTO Printer (Name, AreaId, CreatetAt)
    VALUES (@Name, @AreaId, @CreatetAt);
END;
GO

-- Procedimiento para actualizar en la tabla Printer
CREATE PROCEDURE UpdatePrinter
    @Id INT,
    @Name VARCHAR(255),
    @AreaId INT,
    @CreatetAt DATETIME
AS
BEGIN
    UPDATE Printer
    SET Name = @Name, AreaId = @AreaId, CreatetAt = @CreatetAt
    WHERE Id = @Id;
END;
GO

-- Procedimiento para eliminar en la tabla Printer
CREATE PROCEDURE DeletePrinter
    @Id INT
AS
BEGIN
    DELETE FROM Printer
    WHERE Id = @Id;
END;
GO

-- Procedimiento para obtener un registro de la tabla Printer
CREATE PROCEDURE GetPrinter
    @Id INT
AS
BEGIN
    SELECT * FROM Printer
    WHERE Id = @Id;
END;
GO

-- Procedimiento para obtener todos los registros de la tabla Printer
CREATE PROCEDURE GetAllPrinters
AS
BEGIN
    SELECT * FROM Printer;
END;
GO

CREATE PROCEDURE CreatePrintingArea
    @Name VARCHAR(255),
    @CreatetAt DATETIME
AS
BEGIN
    INSERT INTO PrintingArea (Name, CreatetAt)
    VALUES (@Name, @CreatetAt);
END;
GO

CREATE PROCEDURE UpdatePrintingArea
    @Id INT,
    @Name VARCHAR(255),
    @CreatetAt DATETIME
AS
BEGIN
    UPDATE PrintingArea
    SET Name = @Name, CreatetAt = @CreatetAt
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE DeletePrintingArea
    @Id INT
AS
BEGIN
    DELETE FROM PrintingArea
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE GetPrintingArea
    @Id INT
AS
BEGIN
    SELECT * FROM PrintingArea
    WHERE Id = @Id;
END;
GO

CREATE PROCEDURE GetAllPrintingAreas
AS
BEGIN
    SELECT * FROM PrintingArea;
END;
GO

CREATE PROCEDURE GetSalesForToday
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATETIME = GETDATE();

    SELECT
        s.Id AS SaleId,
        c.Name AS CustomerName,
        s.Address AS ShippingAddress,
        n.Name AS NeighborhoodName,
        tc.Name AS TransportationCompanyName,
        s.PaymentType,
        s.TotalAmount
    FROM
        Sale s
    INNER JOIN
        Customer c ON s.CustomerId = c.Id
    INNER JOIN
        Neighborhood n ON s.NeighborhoodId = n.Id
    INNER JOIN
        TransportationCompany tc ON s.TransportationCompanyId = tc.Id
    WHERE
        CONVERT(DATE, s.CreatedAt) = CONVERT(DATE, @Today);
END;
GO

CREATE PROCEDURE GetSalesForDate
    @TargetDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        s.Id AS SaleId,
        c.Name AS CustomerName,
        s.Address AS ShippingAddress,
        n.Name AS NeighborhoodName,
        tc.Name AS TransportationCompanyName,
        s.PaymentType,
        s.TotalAmount
    FROM
        Sale s
    INNER JOIN
        Customer c ON s.CustomerId = c.Id
    INNER JOIN
        Neighborhood n ON s.NeighborhoodId = n.Id
    INNER JOIN
        TransportationCompany tc ON s.TransportationCompanyId = tc.Id
    WHERE
        CONVERT(DATE, s.CreatedAt) = @TargetDate;
END;
GO

CREATE PROCEDURE GetProductSalesForDate
    @TargetDate DATE
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        p.Name AS ProductName,
        SUM(sd.Quantity) AS TotalQuantity,
        SUM(sd.Quantity * p.Price) AS TotalAmount
    FROM
        Sale s
    INNER JOIN
        SaleDetail sd ON s.Id = sd.SaleId
    INNER JOIN
        Product p ON sd.ProductId = p.Id
    WHERE
        CONVERT(DATE, s.CreatedAt) = @TargetDate
    GROUP BY
        p.Name;
END;
GO

CREATE PROCEDURE GetCashSalesForDate
    @TargetDate DATE
AS
BEGIN
    SELECT ISNULL(SUM(TotalAmount), 0) AS CashSalesAmount
    FROM Sale
    WHERE PaymentType = 'Efectivo' AND CONVERT(DATE, CreatedAt) = @TargetDate;
END;
GO

CREATE PROCEDURE GetDaviplataSalesForDate
    @TargetDate DATE
AS
BEGIN
    SELECT ISNULL(SUM(TotalAmount), 0) AS DaviplataSalesAmount
    FROM Sale
    WHERE PaymentType = 'Daviplata' AND CONVERT(DATE, CreatedAt) = @TargetDate;
END;
GO

CREATE PROCEDURE GetNequiSalesForDate
    @TargetDate DATE
AS
BEGIN
    SELECT ISNULL(SUM(TotalAmount), 0) AS NequiSalesAmount
    FROM Sale
    WHERE PaymentType = 'Nequi' AND CONVERT(DATE, CreatedAt) = @TargetDate;
END;
GO

CREATE PROCEDURE GetProductSalesForToday
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATETIME = GETDATE();

    SELECT
        p.Name AS ProductName,
        SUM(sd.Quantity) AS TotalQuantity,
        SUM(sd.Quantity * p.Price) AS TotalAmount
    FROM
        Sale s
    INNER JOIN
        SaleDetail sd ON s.Id = sd.SaleId
    INNER JOIN
        Product p ON sd.ProductId = p.Id
    WHERE
        CONVERT(DATE, s.CreatedAt) = CONVERT(DATE, @Today)
    GROUP BY
        p.Name;
END;
GO

CREATE PROCEDURE GetCashSalesForToday
AS
BEGIN
    DECLARE @Today DATE = CONVERT(DATE, GETDATE());

    SELECT ISNULL(SUM(TotalAmount), 0) AS CashSalesAmount
    FROM Sale
    WHERE PaymentType = 'Efectivo' AND CONVERT(DATE, CreatedAt) = @Today;
END;
GO

CREATE PROCEDURE GetDaviplataSalesForToday
AS
BEGIN
    DECLARE @Today DATE = CONVERT(DATE, GETDATE());

    SELECT ISNULL(SUM(TotalAmount), 0) AS DaviplataSalesAmount
    FROM Sale
    WHERE PaymentType = 'Daviplata' AND CONVERT(DATE, CreatedAt) = @Today;
END;
GO

CREATE PROCEDURE GetNequiSalesForToday
AS
BEGIN
    DECLARE @Today DATE = CONVERT(DATE, GETDATE());

    SELECT ISNULL(SUM(TotalAmount), 0) AS NequiSalesAmount
    FROM Sale
    WHERE PaymentType = 'Nequi' AND CONVERT(DATE, CreatedAt) = @Today;
END;
GO

CREATE PROCEDURE GetTotalSalesPerDay
AS
BEGIN
    SELECT
        CONVERT(DATE, CreatedAt) AS SaleDate,
        COUNT(Id) AS TotalSales,
        SUM(TotalAmount) AS TotalAmount
    FROM
        Sale
    GROUP BY
        CONVERT(DATE, CreatedAt)
    ORDER BY
        SaleDate DESC;
END;
GO

CREATE PROCEDURE GetCustomerCount
AS
BEGIN
    SELECT COUNT(*) AS CustomerCount FROM Customer;
END;
GO

CREATE PROCEDURE GetSaleCount
AS
BEGIN
    SELECT COUNT(*) AS SaleCount FROM Sale;
END;
GO

CREATE PROCEDURE GetExpenditureCount
AS
BEGIN
    SELECT COUNT(*) AS ExpenditureCount FROM Expenditures;
END;
GO

CREATE PROCEDURE GetTotalSalesAmount
AS
BEGIN
    SELECT SUM(TotalAmount) AS TotalSalesAmount FROM Sale;
END;
GO

CREATE PROCEDURE GetTotalExpenditureAmount
AS
BEGIN
    SELECT SUM(Value) AS TotalExpenditureAmount FROM Expenditures;
END;
GO

CREATE PROCEDURE GetProductSales
AS
BEGIN
    SELECT
        P.Name AS ProductName,
        SUM(SD.Quantity) AS QuantitySold
    FROM
        SaleDetail SD
    INNER JOIN
        Product P ON SD.ProductId = P.Id
    GROUP BY
        P.Name;
END;
GO

CREATE PROCEDURE GetCustomerCountForToday
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATETIME = CONVERT(DATE, GETDATE());

    SELECT COUNT(Id) AS CustomerCount
    FROM Customer
    WHERE CONVERT(DATE, CreatedAt) = @Today;
END;
GO

CREATE PROCEDURE GetTotalSalesAmountForToday
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATETIME = CONVERT(DATE, GETDATE());

    SELECT ISNULL(SUM(TotalAmount), 0) AS TotalSalesAmount
    FROM Sale
    WHERE CONVERT(DATE, CreatedAt) = @Today;
END;
GO

CREATE PROCEDURE GetSalesCountForToday
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATETIME = CONVERT(DATE, GETDATE());

    SELECT COUNT(Id) AS SalesCount
    FROM Sale
    WHERE CONVERT(DATE, CreatedAt) = @Today;
END;
GO

CREATE PROCEDURE GetTotalExpendituresForToday
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATETIME = CONVERT(DATE, GETDATE());

    SELECT ISNULL(SUM(Value), 0) AS TotalExpenditures
    FROM Expenditures
    WHERE CONVERT(DATE, Date) = @Today;
END;
GO
