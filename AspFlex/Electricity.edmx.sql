
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/24/2019 08:40:44
-- Generated from EDMX file: C:\Users\vinograd\source\repos\AspFlex\AspFlex\Electricity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Electricity];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FiderTp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TpSet] DROP CONSTRAINT [FK_FiderTp];
GO
IF OBJECT_ID(N'[dbo].[FK_TpLine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LineSet] DROP CONSTRAINT [FK_TpLine];
GO
IF OBJECT_ID(N'[dbo].[FK_LineCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerSet] DROP CONSTRAINT [FK_LineCustomer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FiderSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FiderSet];
GO
IF OBJECT_ID(N'[dbo].[TpSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TpSet];
GO
IF OBJECT_ID(N'[dbo].[LineSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LineSet];
GO
IF OBJECT_ID(N'[dbo].[CustomerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FiderSet'
CREATE TABLE [dbo].[FiderSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Power] int  NOT NULL,
    [Voltage] int  NOT NULL,
    [Geocode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TpSet'
CREATE TABLE [dbo].[TpSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Power] int  NOT NULL,
    [Voltage] int  NOT NULL,
    [Geocode] nvarchar(max)  NOT NULL,
    [FiderId] int  NOT NULL
);
GO

-- Creating table 'LineSet'
CREATE TABLE [dbo].[LineSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Power] int  NOT NULL,
    [Voltage] int  NOT NULL,
    [Geocode] nvarchar(max)  NOT NULL,
    [TpId] int  NOT NULL
);
GO

-- Creating table 'CustomerSet'
CREATE TABLE [dbo].[CustomerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ObjectName] nvarchar(max)  NOT NULL,
    [PlaceInstall] nvarchar(max)  NOT NULL,
    [Adress] nvarchar(max)  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [LineId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FiderSet'
ALTER TABLE [dbo].[FiderSet]
ADD CONSTRAINT [PK_FiderSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TpSet'
ALTER TABLE [dbo].[TpSet]
ADD CONSTRAINT [PK_TpSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LineSet'
ALTER TABLE [dbo].[LineSet]
ADD CONSTRAINT [PK_LineSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [PK_CustomerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FiderId] in table 'TpSet'
ALTER TABLE [dbo].[TpSet]
ADD CONSTRAINT [FK_FiderTp]
    FOREIGN KEY ([FiderId])
    REFERENCES [dbo].[FiderSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FiderTp'
CREATE INDEX [IX_FK_FiderTp]
ON [dbo].[TpSet]
    ([FiderId]);
GO

-- Creating foreign key on [TpId] in table 'LineSet'
ALTER TABLE [dbo].[LineSet]
ADD CONSTRAINT [FK_TpLine]
    FOREIGN KEY ([TpId])
    REFERENCES [dbo].[TpSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TpLine'
CREATE INDEX [IX_FK_TpLine]
ON [dbo].[LineSet]
    ([TpId]);
GO

-- Creating foreign key on [LineId] in table 'CustomerSet'
ALTER TABLE [dbo].[CustomerSet]
ADD CONSTRAINT [FK_LineCustomer]
    FOREIGN KEY ([LineId])
    REFERENCES [dbo].[LineSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LineCustomer'
CREATE INDEX [IX_FK_LineCustomer]
ON [dbo].[CustomerSet]
    ([LineId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------