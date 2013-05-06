



-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 05/06/2013 19:19:25
-- Generated from EDMX file: C:\Users\Bart\Documents\GitHub\StageManager\StageManager\StageManager\Models\Model1.edmx
-- Target version: 3.0.0.0
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

--    ALTER TABLE `StageSet` DROP CONSTRAINT `FK_StudentStage`;
--    ALTER TABLE `StageSet` DROP CONSTRAINT `FK_LeraarStage`;
--    ALTER TABLE `BedrijfsbegeleiderSet` DROP CONSTRAINT `FK_BedrijfsbegeleiderBedrijf`;
--    ALTER TABLE `StageSet` DROP CONSTRAINT `FK_BedrijfStage`;
--    ALTER TABLE `StageSet` DROP CONSTRAINT `FK_BedrijfsbegeleiderStage`;
--    ALTER TABLE `DocentSet` DROP CONSTRAINT `FK_DocentAlgemeen`;

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `StudentSet`;
    DROP TABLE IF EXISTS `DocentSet`;
    DROP TABLE IF EXISTS `BedrijfsbegeleiderSet`;
    DROP TABLE IF EXISTS `BedrijfSet`;
    DROP TABLE IF EXISTS `StageSet`;
    DROP TABLE IF EXISTS `AlgemeenSet`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

CREATE TABLE `StudentSet`(
	`Studentnummer` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` longtext NOT NULL, 
	`Straatnaam_en_nr` longtext NOT NULL, 
	`Postcode` longtext NOT NULL, 
	`Plaats` longtext NOT NULL, 
	`Telefoonnummer` int NOT NULL, 
	`EC_norm_behaald` bool NOT NULL);

ALTER TABLE `StudentSet` ADD PRIMARY KEY (Studentnummer);




CREATE TABLE `DocentSet`(
	`Leraar_Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Naam` longtext, 
	`Straatnaam_en_nr` longtext, 
	`Postcode` longtext, 
	`Plaats` longtext, 
	`Telefoonnummer` longtext, 
	`Algemene_InformatieId` int NOT NULL, 
	`DBU1` smallint, 
	`DBU2` smallint, 
	`DBU3` smallint, 
	`DBU4` smallint, 
	`AlgemeenId` int NOT NULL);

ALTER TABLE `DocentSet` ADD PRIMARY KEY (Leraar_Id);




CREATE TABLE `BedrijfsbegeleiderSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Naam` longtext NOT NULL, 
	`Functie` longtext, 
	`Telefoonnummer` int, 
	`Email` longtext, 
	`Opleidingsniveau` longtext, 
	`Minimale_begeleidingstijd_gegarandeerd` longtext NOT NULL, 
	`BedrijfBedrijfs_Id` int NOT NULL);

ALTER TABLE `BedrijfsbegeleiderSet` ADD PRIMARY KEY (Id);




CREATE TABLE `BedrijfSet`(
	`Bedrijfs_Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Naam` longtext NOT NULL, 
	`Straatnaam_en_nummer` longtext NOT NULL, 
	`Postcode` longtext NOT NULL, 
	`Plaats` longtext NOT NULL, 
	`Telefoonnummer` int, 
	`Website` longtext);

ALTER TABLE `BedrijfSet` ADD PRIMARY KEY (Bedrijfs_Id);




CREATE TABLE `StageSet`(
	`Start_datum` datetime, 
	`Eind_datum` datetime, 
	`Stageopdracht_omschijving` longtext, 
	`Tools_en_Vaardigheden` longtext, 
	`Risico` longtext, 
	`StudentStudentnummer` int NOT NULL, 
	`LeraarLeraar_Id` int NOT NULL, 
	`BedrijfBedrijfs_Id` int NOT NULL, 
	`BedrijfsbegeleiderId` int NOT NULL, 
	`Stage_Id` int NOT NULL);

ALTER TABLE `StageSet` ADD PRIMARY KEY (Stage_Id);




CREATE TABLE `AlgemeenSet`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Jaargang` datetime NOT NULL, 
	`Werk_Uren` smallint NOT NULL, 
	`Blokken` smallint NOT NULL);

ALTER TABLE `AlgemeenSet` ADD PRIMARY KEY (Id);






-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on `StudentStudentnummer` in table 'StageSet'

ALTER TABLE `StageSet`
ADD CONSTRAINT `FK_StudentStage`
    FOREIGN KEY (`StudentStudentnummer`)
    REFERENCES `StudentSet`
        (`Studentnummer`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentStage'

CREATE INDEX `IX_FK_StudentStage` 
    ON `StageSet`
    (`StudentStudentnummer`);

-- Creating foreign key on `LeraarLeraar_Id` in table 'StageSet'

ALTER TABLE `StageSet`
ADD CONSTRAINT `FK_LeraarStage`
    FOREIGN KEY (`LeraarLeraar_Id`)
    REFERENCES `DocentSet`
        (`Leraar_Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LeraarStage'

CREATE INDEX `IX_FK_LeraarStage` 
    ON `StageSet`
    (`LeraarLeraar_Id`);

-- Creating foreign key on `BedrijfBedrijfs_Id` in table 'BedrijfsbegeleiderSet'

ALTER TABLE `BedrijfsbegeleiderSet`
ADD CONSTRAINT `FK_BedrijfsbegeleiderBedrijf`
    FOREIGN KEY (`BedrijfBedrijfs_Id`)
    REFERENCES `BedrijfSet`
        (`Bedrijfs_Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BedrijfsbegeleiderBedrijf'

CREATE INDEX `IX_FK_BedrijfsbegeleiderBedrijf` 
    ON `BedrijfsbegeleiderSet`
    (`BedrijfBedrijfs_Id`);

-- Creating foreign key on `BedrijfBedrijfs_Id` in table 'StageSet'

ALTER TABLE `StageSet`
ADD CONSTRAINT `FK_BedrijfStage`
    FOREIGN KEY (`BedrijfBedrijfs_Id`)
    REFERENCES `BedrijfSet`
        (`Bedrijfs_Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BedrijfStage'

CREATE INDEX `IX_FK_BedrijfStage` 
    ON `StageSet`
    (`BedrijfBedrijfs_Id`);

-- Creating foreign key on `BedrijfsbegeleiderId` in table 'StageSet'

ALTER TABLE `StageSet`
ADD CONSTRAINT `FK_BedrijfsbegeleiderStage`
    FOREIGN KEY (`BedrijfsbegeleiderId`)
    REFERENCES `BedrijfsbegeleiderSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BedrijfsbegeleiderStage'

CREATE INDEX `IX_FK_BedrijfsbegeleiderStage` 
    ON `StageSet`
    (`BedrijfsbegeleiderId`);

-- Creating foreign key on `AlgemeenId` in table 'DocentSet'

ALTER TABLE `DocentSet`
ADD CONSTRAINT `FK_DocentAlgemeen`
    FOREIGN KEY (`AlgemeenId`)
    REFERENCES `AlgemeenSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DocentAlgemeen'

CREATE INDEX `IX_FK_DocentAlgemeen` 
    ON `DocentSet`
    (`AlgemeenId`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
