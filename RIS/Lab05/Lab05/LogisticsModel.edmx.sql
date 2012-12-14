
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/14/2012 03:30:06
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

IF OBJECT_ID(N'[dbo].[FK_CargoCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cargos] DROP CONSTRAINT [FK_CargoCar];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cargos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cargos];
GO
IF OBJECT_ID(N'[dbo].[Cars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cars];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cargos'
CREATE TABLE [dbo].[Cargos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Size] int  NOT NULL,
    [Price] float  NOT NULL
);
GO

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Capacity] float  NOT NULL,
    [Trips] int  NOT NULL,
    [Cargo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cargos'
ALTER TABLE [dbo].[Cargos]
ADD CONSTRAINT [PK_Cargos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cargo_Id] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_CargoCar]
    FOREIGN KEY ([Cargo_Id])
    REFERENCES [dbo].[Cargos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CargoCar'
CREATE INDEX [IX_FK_CargoCar]
ON [dbo].[Cars]
    ([Cargo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------