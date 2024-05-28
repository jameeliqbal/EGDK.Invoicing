IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Categories] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240526193543_InitialWithCategory', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO Categories (Name, Description) VALUES ('CategoryOne','Description of CategoryOne')
GO

INSERT INTO Categories (Name, Description) VALUES ('CategoryTwo','Description of CategoryTwo')
GO

INSERT INTO Categories (Name, Description) VALUES ('CategoryThree','Description of CategoryThree')
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240526195422_SeedCategories', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Products] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Price] float NOT NULL,
    [Quantity] int NOT NULL,
    [CategoryId] int NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240527050003_ProductEntityAndCategoryRelation3', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO Products (Name,Description, Price, Quantity,CategoryId) Values ('ProductOne','Description of ProductOne',100,10, (SELECT Id FROM Categories WHERE Name = 'CategoryOne'))
GO

INSERT INTO Products (Name,Description, Price, Quantity,CategoryId) Values ('ProductTwo','Description of ProductTwo',200,20, (SELECT Id FROM Categories WHERE Name = 'CategoryTwo'))
GO

INSERT INTO Products (Name,Description, Price, Quantity,CategoryId) Values ('ProductThree','Description of ProductThree',300,30, (SELECT Id FROM Categories WHERE Name = 'CategoryTwo'))
GO

INSERT INTO Products (Name,Description, Price, Quantity,CategoryId) Values ('ProductFour','Description of ProductFour',400,40, (SELECT Id FROM Categories WHERE Name = 'CategoryThree'))
GO

INSERT INTO Products (Name,Description, Price, Quantity,CategoryId) Values ('ProductFive','Description of ProductFive',500,50, (SELECT Id FROM Categories WHERE Name = 'CategoryThree'))
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240527050323_SeedProducts', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Name');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var0 + '];');
UPDATE [Products] SET [Name] = N'' WHERE [Name] IS NULL;
ALTER TABLE [Products] ALTER COLUMN [Name] nvarchar(50) NOT NULL;
ALTER TABLE [Products] ADD DEFAULT N'' FOR [Name];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'Description');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Products] ALTER COLUMN [Description] nvarchar(255) NULL;
GO

CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [Email] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [Phone] nvarchar(max) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240527072527_CustomerEntity', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO Customers (Name, Email, Address, Phone) VALUES ('CustomerOne','customer@one.com','Address of CustomerOne','1111111111')
GO

INSERT INTO Customers (Name, Email, Address, Phone) VALUES ('CustomerTwo','customer@two.com','Address of CustomerTwo','2222222222')
GO

INSERT INTO Customers (Name, Email, Address, Phone) VALUES ('CustomerThree','customer@three.com','Address of CustomerThree','3333333333')
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240527075456_SeedCustomer', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Invoices] (
    [Id] int NOT NULL IDENTITY,
    [InvoiceNumber] nvarchar(max) NULL,
    [InvoiceDate] datetime2 NOT NULL,
    [Total] float NOT NULL,
    [Discount] float NOT NULL,
    [IsDiscountInPercentage] bit NOT NULL,
    [PaymentMode] nvarchar(max) NULL,
    [CustomerId] int NOT NULL,
    CONSTRAINT [PK_Invoices] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Invoices_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [LineItems] (
    [Id] int NOT NULL IDENTITY,
    [Quantity] int NOT NULL,
    [Amount] float NOT NULL,
    [InvoiceId] int NOT NULL,
    [ProdcutId] int NOT NULL,
    CONSTRAINT [PK_LineItems] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_LineItems_Invoices_InvoiceId] FOREIGN KEY ([InvoiceId]) REFERENCES [Invoices] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Invoices_CustomerId] ON [Invoices] ([CustomerId]);
GO

CREATE INDEX [IX_LineItems_InvoiceId] ON [LineItems] ([InvoiceId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240527112324_InvoiceImpl2', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[LineItems].[ProdcutId]', N'ProductId', N'COLUMN';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240527113208_InvoiceLineItemFieldProductIdFix', N'7.0.19');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO Invoices (InvoiceNumber, InvoiceDate,Total,Discount,IsDiscountInPercentage,PaymentMode,CustomerId) VALUES ('0001','20240518 10:34:09 AM',1000,10,1,'Cash',(SELECT Id FROM Customers WHERE Name = 'CustomerOne'))
GO

INSERT INTO Invoices (InvoiceNumber, InvoiceDate,Total,Discount,IsDiscountInPercentage,PaymentMode,CustomerId) VALUES ('0002','20240518 10:34:09 AM',2000,20,1,'Cash',(SELECT Id FROM Customers WHERE Name = 'CustomerTwo'))
GO

INSERT INTO Invoices (InvoiceNumber, InvoiceDate,Total,Discount,IsDiscountInPercentage,PaymentMode,CustomerId) VALUES ('0003','20240518 10:34:09 AM',3000,500,0,'Card',(SELECT Id FROM Customers WHERE Name = 'CustomerThree'))
GO

INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0001'),(SELECT Id FROM Products WHERE Name='ProductOne'))
GO

INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0002'),(SELECT Id FROM Products WHERE Name='ProductOne'))
GO

INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0002'),(SELECT Id FROM Products WHERE Name='ProductTwo'))
GO

INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0003'),(SELECT Id FROM Products WHERE Name='ProductOne'))
GO

INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0003'),(SELECT Id FROM Products WHERE Name='ProductTwo'))
GO

INSERT INTO LineItems (Quantity, Amount,InvoiceId,ProductId) VALUES (1,1000,(SELECT Id FROM Invoices WHERE InvoiceNumber = '0003'),(SELECT Id FROM Products WHERE Name='ProductThree'))
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240527113340_SeedInvoices', N'7.0.19');
GO

COMMIT;
GO

