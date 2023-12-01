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

CREATE TABLE [Category] (
    [CategoryId] int NOT NULL IDENTITY,
    [CategoryName] nvarchar(max) NOT NULL,
    [CategoryCode] nvarchar(max) NOT NULL,
    [CategoryDescription] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([CategoryId])
);
GO

CREATE TABLE [Supplier] (
    [SupplierId] int NOT NULL IDENTITY,
    [SupplierName] nvarchar(max) NOT NULL,
    [Phone] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [ProductId] int NOT NULL,
    CONSTRAINT [PK_Supplier] PRIMARY KEY ([SupplierId])
);
GO

CREATE TABLE [product_tbl] (
    [ProductId] int NOT NULL IDENTITY,
    [ProductName] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NULL,
    [Price] int NOT NULL,
    [Manufactory] nvarchar(max) NOT NULL,
    [createDate] datetime2 NOT NULL,
    [expireDate] datetime2 NOT NULL,
    [isDiscount] bit NOT NULL,
    [DiscountPercent] decimal(18,2) NULL,
    [SupplierId] int NOT NULL,
    CONSTRAINT [PK_product_tbl] PRIMARY KEY ([ProductId]),
    CONSTRAINT [FK_product_tbl_Supplier_SupplierId] FOREIGN KEY ([SupplierId]) REFERENCES [Supplier] ([SupplierId]) ON DELETE CASCADE
);
GO

CREATE TABLE [product_category_tbl] (
    [ProductId] int NOT NULL,
    [CategoryId] int NOT NULL,
    [ProductCategoryRelId] int NOT NULL,
    CONSTRAINT [PK_product_category_tbl] PRIMARY KEY ([ProductId], [CategoryId]),
    CONSTRAINT [FK_product_category_tbl_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([CategoryId]) ON DELETE CASCADE,
    CONSTRAINT [FK_product_category_tbl_product_tbl_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [product_tbl] ([ProductId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_product_category_tbl_CategoryId] ON [product_category_tbl] ([CategoryId]);
GO

CREATE INDEX [IX_product_tbl_SupplierId] ON [product_tbl] ([SupplierId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231020073019_InitProductDB', N'7.0.12');
GO

COMMIT;
GO

