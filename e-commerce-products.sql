IF EXISTS( SELECT name FROM master.dbo.sysdatabases WHERE name = N'ECommerceProductDB')
BEGIN
	USE master;
    DROP DATABASE [ECommerceProductDB];
	PRINT 'ECommerceProductDB DELETED';
END

USE master;

CREATE DATABASE [ECommerceProductDB];
PRINT 'ECommerceProductDB CREATED';
--GO;

USE [ECommerceProductDB];
--GO;

CREATE TABLE [Categories]
(
	Id			UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID() NOT NULL,
	Name		VARCHAR(50) NOT NULL,
	Description	VARCHAR(100) NOT NULL,
	IsActive	BIT NOT NULL,
);

INSERT INTO [Categories] VALUES(NEWID(), 'Calzado', 'Todos los productso relacionado a calzado', 1);
INSERT INTO [Categories] VALUES(NEWID(), 'Lacteaos', 'Todos los productso relacionado a lacteos', 1);
INSERT INTO [Categories] VALUES(NEWID(), 'Organico', 'Todos los productso que sean organicos', 1);

SELECT	*
FROM	[Categories]

CREATE TABLE [Products]
(
	Id			UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID() NOT NULL,
	Name		VARCHAR(50),
	Description	VARCHAR(100),
	Stock		INT,
	UnitPrice	DECIMAL(18, 2),
	IsActive	BIT,
	CategoryId	UNIQUEIDENTIFIER

	FOREIGN KEY(CategoryId) REFERENCES [Categories](Id)
);
