
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/06/2013 15:17:21
-- Generated from EDMX file: C:\Users\Eigenaar\Documents\GitHub\StageManager\StageManager\StageManager\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Stagemanager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'StudentSet'
CREATE TABLE [dbo].[StudentSet] (
    [Studentnummer] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(1000)  NOT NULL,
    [Straatnaam_en_nr] varchar(1000)  NOT NULL,
    [Postcode] varchar(1000)  NOT NULL,
    [Plaats] varchar(1000)  NOT NULL,
    [Telefoonnummer] int  NOT NULL,
    [EC_norm_behaald] bool  NOT NULL
);
GO

-- Creating table 'DocentSet'
CREATE TABLE [dbo].[DocentSet] (
    [Leraar_Id] int IDENTITY(1,1) NOT NULL,
    [Naam] varchar(1000)  NULL,
    [Straatnaam_en_nr] varchar(1000)  NULL,
    [Postcode] varchar(1000)  NULL,
    [Plaats] varchar(1000)  NULL,
    [Telefoonnummer] varchar(1000)  NULL,
    [Algemene_InformatieId] int  NOT NULL,
    [DBU1] smallint  NULL,
    [DBU2] smallint  NULL,
    [DBU3] smallint  NULL,
    [DBU4] smallint  NULL,
    [AlgemeenId] int  NOT NULL
);
GO

-- Creating table 'BedrijfsbegeleiderSet'
CREATE TABLE [dbo].[BedrijfsbegeleiderSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Naam] varchar(1000)  NOT NULL,
    [Functie] varchar(1000)  NULL,
    [Telefoonnummer] int  NULL,
    [Email] varchar(1000)  NULL,
    [Opleidingsniveau] varchar(1000)  NULL,
    [Minimale_begeleidingstijd_gegarandeerd] varchar(1000)  NOT NULL,
    [BedrijfBedrijfs_Id] int  NOT NULL
);
GO

-- Creating table 'BedrijfSet'
CREATE TABLE [dbo].[BedrijfSet] (
    [Bedrijfs_Id] int IDENTITY(1,1) NOT NULL,
    [Naam] varchar(1000)  NOT NULL,
    [Straatnaam_en_nummer] varchar(1000)  NOT NULL,
    [Postcode] varchar(1000)  NOT NULL,
    [Plaats] varchar(1000)  NOT NULL,
    [Telefoonnummer] int  NULL,
    [Website] varchar(1000)  NULL
);
GO

-- Creating table 'StageSet'
CREATE TABLE [dbo].[StageSet] (
    [Start_datum] datetime  NULL,
    [Eind_datum] datetime  NULL,
    [Stageopdracht_omschijving] varchar(1000)  NULL,
    [Tools_en_Vaardigheden] varchar(1000)  NULL,
    [Risico] varchar(1000)  NULL,
    [StudentStudentnummer] int  NOT NULL,
    [LeraarLeraar_Id] int  NOT NULL,
    [BedrijfBedrijfs_Id] int  NOT NULL,
    [BedrijfsbegeleiderId] int  NOT NULL,
    [Stage_Id] int  NOT NULL
);
GO

-- Creating table 'AlgemeenSet'
CREATE TABLE [dbo].[AlgemeenSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Jaargang] datetime  NOT NULL,
    [Werk_Uren] smallint  NOT NULL,
    [Blokken] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Studentnummer] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [PK_StudentSet]
    PRIMARY KEY CLUSTERED ([Studentnummer] ASC);
GO

-- Creating primary key on [Leraar_Id] in table 'DocentSet'
ALTER TABLE [dbo].[DocentSet]
ADD CONSTRAINT [PK_DocentSet]
    PRIMARY KEY CLUSTERED ([Leraar_Id] ASC);
GO

-- Creating primary key on [Id] in table 'BedrijfsbegeleiderSet'
ALTER TABLE [dbo].[BedrijfsbegeleiderSet]
ADD CONSTRAINT [PK_BedrijfsbegeleiderSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Bedrijfs_Id] in table 'BedrijfSet'
ALTER TABLE [dbo].[BedrijfSet]
ADD CONSTRAINT [PK_BedrijfSet]
    PRIMARY KEY CLUSTERED ([Bedrijfs_Id] ASC);
GO

-- Creating primary key on [Stage_Id] in table 'StageSet'
ALTER TABLE [dbo].[StageSet]
ADD CONSTRAINT [PK_StageSet]
    PRIMARY KEY CLUSTERED ([Stage_Id] ASC);
GO

-- Creating primary key on [Id] in table 'AlgemeenSet'
ALTER TABLE [dbo].[AlgemeenSet]
ADD CONSTRAINT [PK_AlgemeenSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentStudentnummer] in table 'StageSet'
ALTER TABLE [dbo].[StageSet]
ADD CONSTRAINT [FK_StudentStage]
    FOREIGN KEY ([StudentStudentnummer])
    REFERENCES [dbo].[StudentSet]
        ([Studentnummer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentStage'
CREATE INDEX [IX_FK_StudentStage]
ON [dbo].[StageSet]
    ([StudentStudentnummer]);
GO

-- Creating foreign key on [LeraarLeraar_Id] in table 'StageSet'
ALTER TABLE [dbo].[StageSet]
ADD CONSTRAINT [FK_LeraarStage]
    FOREIGN KEY ([LeraarLeraar_Id])
    REFERENCES [dbo].[DocentSet]
        ([Leraar_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LeraarStage'
CREATE INDEX [IX_FK_LeraarStage]
ON [dbo].[StageSet]
    ([LeraarLeraar_Id]);
GO

-- Creating foreign key on [BedrijfBedrijfs_Id] in table 'BedrijfsbegeleiderSet'
ALTER TABLE [dbo].[BedrijfsbegeleiderSet]
ADD CONSTRAINT [FK_BedrijfsbegeleiderBedrijf]
    FOREIGN KEY ([BedrijfBedrijfs_Id])
    REFERENCES [dbo].[BedrijfSet]
        ([Bedrijfs_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BedrijfsbegeleiderBedrijf'
CREATE INDEX [IX_FK_BedrijfsbegeleiderBedrijf]
ON [dbo].[BedrijfsbegeleiderSet]
    ([BedrijfBedrijfs_Id]);
GO

-- Creating foreign key on [BedrijfBedrijfs_Id] in table 'StageSet'
ALTER TABLE [dbo].[StageSet]
ADD CONSTRAINT [FK_BedrijfStage]
    FOREIGN KEY ([BedrijfBedrijfs_Id])
    REFERENCES [dbo].[BedrijfSet]
        ([Bedrijfs_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BedrijfStage'
CREATE INDEX [IX_FK_BedrijfStage]
ON [dbo].[StageSet]
    ([BedrijfBedrijfs_Id]);
GO

-- Creating foreign key on [BedrijfsbegeleiderId] in table 'StageSet'
ALTER TABLE [dbo].[StageSet]
ADD CONSTRAINT [FK_BedrijfsbegeleiderStage]
    FOREIGN KEY ([BedrijfsbegeleiderId])
    REFERENCES [dbo].[BedrijfsbegeleiderSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BedrijfsbegeleiderStage'
CREATE INDEX [IX_FK_BedrijfsbegeleiderStage]
ON [dbo].[StageSet]
    ([BedrijfsbegeleiderId]);
GO

-- Creating foreign key on [AlgemeenId] in table 'DocentSet'
ALTER TABLE [dbo].[DocentSet]
ADD CONSTRAINT [FK_DocentAlgemeen]
    FOREIGN KEY ([AlgemeenId])
    REFERENCES [dbo].[AlgemeenSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DocentAlgemeen'
CREATE INDEX [IX_FK_DocentAlgemeen]
ON [dbo].[DocentSet]
    ([AlgemeenId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------