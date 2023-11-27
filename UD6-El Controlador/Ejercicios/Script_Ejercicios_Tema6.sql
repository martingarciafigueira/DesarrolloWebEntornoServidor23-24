DROP DATABASE IF EXISTS Ejercicios_Tema6;
GO
CREATE DATABASE Ejercicios_Tema6;
GO
USE Ejercicios_Tema6;
GO
CREATE TABLE [dbo].[Contacts] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL,
    [Email] NVARCHAR(50) NOT NULL,
    [Message] NVARCHAR(MAX) NOT NULL
);

INSERT INTO [dbo].[Contacts] ([Name], [Email], [Message]) VALUES ('John Doe', 'john.doe@example.com', 'Hello world');
INSERT INTO [dbo].[Contacts] ([Name], [Email], [Message]) VALUES ('Jane Doe', 'jane.doe@example.com', 'Lorem ipsum dolor sit amet');
INSERT INTO [dbo].[Contacts] ([Name], [Email], [Message]) VALUES ('Bob Smith', 'bob.smith@example.com', 'Consectetur adipiscing elit');

CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO [dbo].[Customers] ([FirstName], [LastName], [Email], [Address], [City], [State], [Country], [PostalCode])
VALUES ('John', 'Doe', 'johndoe@example.com', '123 Main St', 'Anytown', 'CA', 'USA', '12345');
INSERT INTO [dbo].[Customers] ([FirstName], [LastName], [Email], [Address], [City], [State], [Country], [PostalCode])
VALUES ('Jane', 'Doe', 'janedoe@example.com', '456 Oak St', 'Othertown', 'NY', 'USA', '67890');
INSERT INTO [dbo].[Customers] ([FirstName], [LastName], [Email], [Address], [City], [State], [Country], [PostalCode])
VALUES ('Bob', 'Smith', 'bobsmith@example.com', '789 Elm St', 'Sometown', 'FL', 'USA', '24680');

CREATE TABLE [dbo].[Products] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL,
    [Description] NVARCHAR(MAX) NULL,
    [Price] DECIMAL(18,2) NOT NULL
);

INSERT INTO [dbo].[Products] ([Name], [Description], [Price]) VALUES ('Product 1', 'Description for Product 1', 10.00);
INSERT INTO [dbo].[Products] ([Name], [Description], [Price]) VALUES ('Product 2', 'Description for Product 2', 20.00);
INSERT INTO [dbo].[Products] ([Name], [Description], [Price]) VALUES ('Product 3', 'Description for Product 3', 30.00);

CREATE TABLE [dbo].[Orders] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [CustomerId] INT NOT NULL,
    [OrderDate] DATETIME NOT NULL,
    [TotalAmount] DECIMAL(18,2) NOT NULL,
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id])
);

CREATE TABLE [dbo].[OrderItems] (
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [OrderId] INT NOT NULL,
    [ProductId] INT NOT NULL,
    [Quantity] INT NOT NULL,
    [Price] DECIMAL(18,2) NOT NULL,
    CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([Id]),
    CONSTRAINT [FK_OrderItems_Products] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id])
);

DECLARE @johnDoeCustomerId INT = SCOPE_IDENTITY();
DECLARE @janeDoeCustomerId INT = SCOPE_IDENTITY();

INSERT INTO [dbo].[Orders] ([CustomerId], [OrderDate], [TotalAmount]) VALUES (@johnDoeCustomerId, '2022-05-07 10:30:00', 50.00);

DECLARE @orderId INT = SCOPE_IDENTITY();

INSERT INTO [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [Price]) VALUES (@orderId, 1, 2, 20.00);
INSERT INTO [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [Price]) VALUES (@orderId, 2, 3, 30.00);

INSERT INTO [dbo].[Orders] ([CustomerId], [OrderDate], [TotalAmount]) VALUES (@janeDoeCustomerId, '2022-05-07 12:30:00', 70.00);

SET @orderId = SCOPE_IDENTITY();

INSERT INTO [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [Price]) VALUES (@orderId, 2, 2, 40.00);
INSERT INTO [dbo].[OrderItems] ([OrderId], [ProductId], [Quantity], [Price]) VALUES (@orderId, 3, 1, 30.00);

CREATE TABLE [dbo].[Fibonacci] (
    [Number] INT NOT NULL PRIMARY KEY,
    [Result] BIGINT NOT NULL
);

INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (0, 0);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (1, 1);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (2, 1);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (3, 2);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (4, 3);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (5, 5);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (6, 8);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (7, 13);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (8, 21);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (9, 34);
INSERT INTO [dbo].[Fibonacci] ([Number], [Result]) VALUES (10, 55);

