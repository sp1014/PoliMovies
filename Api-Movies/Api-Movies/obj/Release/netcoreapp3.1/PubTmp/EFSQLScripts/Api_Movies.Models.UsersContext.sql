IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Colectionses] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Colectionses] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Files] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Archivo] nvarchar(max) NULL,
        CONSTRAINT [PK_Files] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Invoices] (
        [Id] int NOT NULL IDENTITY,
        [status] bit NOT NULL,
        CONSTRAINT [PK_Invoices] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Qualifications] (
        [Id] int NOT NULL IDENTITY,
        [Qualifications] nvarchar(max) NULL,
        [Commentary] nvarchar(max) NULL,
        CONSTRAINT [PK_Qualifications] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Rentales] (
        [Id] int NOT NULL IDENTITY,
        [NameProduct] nvarchar(max) NULL,
        [Quantity] int NOT NULL,
        [PriceRental] int NOT NULL,
        [DateInitRental] datetime2 NOT NULL,
        [DateEndRental] datetime2 NOT NULL,
        CONSTRAINT [PK_Rentales] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Roles] (
        [Id] int NOT NULL IDENTITY,
        [NameRole] nvarchar(max) NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Sales] (
        [Id] int NOT NULL IDENTITY,
        [date] datetime2 NOT NULL,
        [totalPrice] int NOT NULL,
        [quantity] int NOT NULL,
        CONSTRAINT [PK_Sales] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Series] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [season] nvarchar(max) NULL,
        CONSTRAINT [PK_Series] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [TypeDocs] (
        [Id] int NOT NULL IDENTITY,
        [NameTypeDoc] nvarchar(max) NULL,
        CONSTRAINT [PK_TypeDocs] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Movies] (
        [Id] int NOT NULL IDENTITY,
        [TitleMovie] nvarchar(max) NULL,
        [DateProduction] datetime2 NOT NULL,
        [Duration] nvarchar(max) NULL,
        [Actors] nvarchar(max) NULL,
        [Directors] nvarchar(max) NULL,
        [Producers] nvarchar(max) NULL,
        [IdRental] int NOT NULL,
        [IdSale] int NOT NULL,
        [IdQualification] int NOT NULL,
        [IdSerie] int NOT NULL,
        [IdFile] int NOT NULL,
        [IdColections] int NOT NULL,
        CONSTRAINT [PK_Movies] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Movies_Colectionses_IdColections] FOREIGN KEY ([IdColections]) REFERENCES [Colectionses] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Movies_Files_IdFile] FOREIGN KEY ([IdFile]) REFERENCES [Files] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Movies_Qualifications_IdQualification] FOREIGN KEY ([IdQualification]) REFERENCES [Qualifications] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Movies_Rentales_IdRental] FOREIGN KEY ([IdRental]) REFERENCES [Rentales] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Movies_Sales_IdSale] FOREIGN KEY ([IdSale]) REFERENCES [Sales] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Movies_Series_IdSerie] FOREIGN KEY ([IdSerie]) REFERENCES [Series] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Users] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Password] nvarchar(max) NULL,
        [Doc] nvarchar(max) NULL,
        [Status] bit NOT NULL,
        [IdRol] int NOT NULL,
        [IdTypeDoc] int NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Users_Roles_IdRol] FOREIGN KEY ([IdRol]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Users_TypeDocs_IdTypeDoc] FOREIGN KEY ([IdTypeDoc]) REFERENCES [TypeDocs] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Categories] (
        [Id] int NOT NULL IDENTITY,
        [NameCategory] nvarchar(max) NULL,
        [IdMovie] int NOT NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Categories_Movies_IdMovie] FOREIGN KEY ([IdMovie]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Idioms] (
        [Id] int NOT NULL IDENTITY,
        [Lenguage] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Doblaje] nvarchar(max) NULL,
        [IdMovie] int NOT NULL,
        CONSTRAINT [PK_Idioms] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Idioms_Movies_IdMovie] FOREIGN KEY ([IdMovie]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [DetailRentales] (
        [Id] int NOT NULL IDENTITY,
        [Detail] nvarchar(max) NULL,
        [IdUser] int NOT NULL,
        [IdRental] int NOT NULL,
        CONSTRAINT [PK_DetailRentales] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_DetailRentales_Rentales_IdRental] FOREIGN KEY ([IdRental]) REFERENCES [Rentales] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_DetailRentales_Users_IdUser] FOREIGN KEY ([IdUser]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [DetailSales] (
        [Id] int NOT NULL IDENTITY,
        [Detail] nvarchar(max) NULL,
        [IdUser] int NOT NULL,
        [IdSale] int NOT NULL,
        CONSTRAINT [PK_DetailSales] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_DetailSales_Sales_IdSale] FOREIGN KEY ([IdSale]) REFERENCES [Sales] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_DetailSales_Users_IdUser] FOREIGN KEY ([IdUser]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE TABLE [Pqrs] (
        [Id] int NOT NULL IDENTITY,
        [Description] nvarchar(max) NULL,
        [date] datetime2 NOT NULL,
        [IdUser] int NOT NULL,
        CONSTRAINT [PK_Pqrs] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Pqrs_Users_IdUser] FOREIGN KEY ([IdUser]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Categories_IdMovie] ON [Categories] ([IdMovie]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_DetailRentales_IdRental] ON [DetailRentales] ([IdRental]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_DetailRentales_IdUser] ON [DetailRentales] ([IdUser]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_DetailSales_IdSale] ON [DetailSales] ([IdSale]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_DetailSales_IdUser] ON [DetailSales] ([IdUser]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Idioms_IdMovie] ON [Idioms] ([IdMovie]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Movies_IdColections] ON [Movies] ([IdColections]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Movies_IdFile] ON [Movies] ([IdFile]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Movies_IdQualification] ON [Movies] ([IdQualification]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Movies_IdRental] ON [Movies] ([IdRental]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Movies_IdSale] ON [Movies] ([IdSale]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Movies_IdSerie] ON [Movies] ([IdSerie]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Pqrs_IdUser] ON [Pqrs] ([IdUser]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Users_IdRol] ON [Users] ([IdRol]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    CREATE INDEX [IX_Users_IdTypeDoc] ON [Users] ([IdTypeDoc]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220925024128_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220925024128_Initial', N'3.1.7');
END;

GO

