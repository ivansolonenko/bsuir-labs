
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/22/2012 14:38:05
-- Generated from EDMX file: C:\Users\cruazer\Documents\Projects\cruazer-bsuir\RIS\Lab05\Lab05\LogisticsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RiS.Lab05];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CargoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CargoSet];
GO
IF OBJECT_ID(N'[dbo].[CarSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CargoSet'
CREATE TABLE [dbo].[CargoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CargoTitle] nvarchar(max)  NOT NULL,
    [CargoSize] int  NOT NULL
);
GO

-- Creating table 'CarSet'
CREATE TABLE [dbo].[CarSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Capacity] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CargoSet'
ALTER TABLE [dbo].[CargoSet]
ADD CONSTRAINT [PK_CargoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CarSet'
ALTER TABLE [dbo].[CarSet]
ADD CONSTRAINT [PK_CarSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------