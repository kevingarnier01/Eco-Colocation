
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/25/2019 12:44:47
-- Generated from EDMX file: C:\Users\kev-gar\Documents\Projet personnel\Eco-colocation\Application\Développement\Eco-Colocation\Eco-Colocation\Controllers\EcoColocationModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EcoColocationDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Location_ChambreLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChambreLocation] DROP CONSTRAINT [FK_Location_ChambreLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetCreation_Lieu_ProjetCreation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetCreation_Lieu] DROP CONSTRAINT [FK_ProjetCreation_Lieu_ProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetCreation_Lieu_Lieu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetCreation_Lieu] DROP CONSTRAINT [FK_ProjetCreation_Lieu_Lieu];
GO
IF OBJECT_ID(N'[dbo].[FK_Lieu_RechercheColoc_RechercheColoc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lieu_RechercheColoc] DROP CONSTRAINT [FK_Lieu_RechercheColoc_RechercheColoc];
GO
IF OBJECT_ID(N'[dbo].[FK_Lieu_RechercheColoc_Lieu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lieu_RechercheColoc] DROP CONSTRAINT [FK_Lieu_RechercheColoc_Lieu];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateur_Role_Utilisateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Utilisateur_Role] DROP CONSTRAINT [FK_Utilisateur_Role_Utilisateur];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateur_Role_Role]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Utilisateur_Role] DROP CONSTRAINT [FK_Utilisateur_Role_Role];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateur_ProjetCreation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetCreation] DROP CONSTRAINT [FK_Utilisateur_ProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateur_Location]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnnonceLocation] DROP CONSTRAINT [FK_Utilisateur_Location];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateur_EvenementPresence]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementPresence] DROP CONSTRAINT [FK_Utilisateur_EvenementPresence];
GO
IF OBJECT_ID(N'[dbo].[FK_Evenement_EvenementPresence]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementPresence] DROP CONSTRAINT [FK_Evenement_EvenementPresence];
GO
IF OBJECT_ID(N'[dbo].[FK_Evenement_EvenementAssocie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementAssocie] DROP CONSTRAINT [FK_Evenement_EvenementAssocie];
GO
IF OBJECT_ID(N'[dbo].[FK_Evenement_EvenementAssocie1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementAssocie] DROP CONSTRAINT [FK_Evenement_EvenementAssocie1];
GO
IF OBJECT_ID(N'[dbo].[FK_ConversationDev_ImageConversationDev]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageConversationDev] DROP CONSTRAINT [FK_ConversationDev_ImageConversationDev];
GO
IF OBJECT_ID(N'[dbo].[FK_Adhesion_Utilisateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Adhesion] DROP CONSTRAINT [FK_Adhesion_Utilisateur];
GO
IF OBJECT_ID(N'[dbo].[FK_EcoColocExistante_ImageEcoColocEx]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageEcoColocEx] DROP CONSTRAINT [FK_EcoColocExistante_ImageEcoColocEx];
GO
IF OBJECT_ID(N'[dbo].[FK_Utilisateur_Evenement]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evenement] DROP CONSTRAINT [FK_Utilisateur_Evenement];
GO
IF OBJECT_ID(N'[dbo].[FK_ConversationDev_Utilisateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConversationDev] DROP CONSTRAINT [FK_ConversationDev_Utilisateur];
GO
IF OBJECT_ID(N'[dbo].[FK_Colocataire_EcoColocExistante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Colocataire] DROP CONSTRAINT [FK_Colocataire_EcoColocExistante];
GO
IF OBJECT_ID(N'[dbo].[FK_ImageProjetCreation_ProjetCreation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageProjetCreation] DROP CONSTRAINT [FK_ImageProjetCreation_ProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[FK_RechercheColocation_Utilisateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RechercheColocation] DROP CONSTRAINT [FK_RechercheColocation_Utilisateur];
GO
IF OBJECT_ID(N'[dbo].[FK_EcoColocExistante_Utilisateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EcoColocExistante] DROP CONSTRAINT [FK_EcoColocExistante_Utilisateur];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AnnonceLocation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnnonceLocation];
GO
IF OBJECT_ID(N'[dbo].[ChambreLocation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChambreLocation];
GO
IF OBJECT_ID(N'[dbo].[ProjetCreation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[Lieu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lieu];
GO
IF OBJECT_ID(N'[dbo].[Evenement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Evenement];
GO
IF OBJECT_ID(N'[dbo].[EvenementPresence]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvenementPresence];
GO
IF OBJECT_ID(N'[dbo].[EcoColocExistante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EcoColocExistante];
GO
IF OBJECT_ID(N'[dbo].[ImageConversationDev]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImageConversationDev];
GO
IF OBJECT_ID(N'[dbo].[Colocataire]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Colocataire];
GO
IF OBJECT_ID(N'[dbo].[ConversationDev]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConversationDev];
GO
IF OBJECT_ID(N'[dbo].[RechercheColocation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RechercheColocation];
GO
IF OBJECT_ID(N'[dbo].[Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Role];
GO
IF OBJECT_ID(N'[dbo].[Utilisateur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Utilisateur];
GO
IF OBJECT_ID(N'[dbo].[EvenementAssocie]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvenementAssocie];
GO
IF OBJECT_ID(N'[dbo].[Adhesion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Adhesion];
GO
IF OBJECT_ID(N'[dbo].[ImageEcoColocEx]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImageEcoColocEx];
GO
IF OBJECT_ID(N'[dbo].[ImageProjetCreation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImageProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[ProjetCreation_Lieu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjetCreation_Lieu];
GO
IF OBJECT_ID(N'[dbo].[Lieu_RechercheColoc]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lieu_RechercheColoc];
GO
IF OBJECT_ID(N'[dbo].[Utilisateur_Role]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Utilisateur_Role];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AnnonceLocation'
CREATE TABLE [dbo].[AnnonceLocation] (
    [IdAnnonceLocation] int IDENTITY(1,1) NOT NULL,
    [IdUtilisateur] int  NOT NULL,
    [Introduction] nvarchar(110)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Rue] nvarchar(80)  NOT NULL,
    [Ville] nvarchar(50)  NOT NULL,
    [CodePostal] nvarchar(15)  NOT NULL,
    [Departement] nvarchar(50)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [Pays] nvarchar(50)  NOT NULL,
    [Latitude] int  NOT NULL,
    [Longitude] int  NOT NULL,
    [TypeLogement] tinyint  NOT NULL,
    [ImplantationLogement] tinyint  NOT NULL,
    [SuperficieLogement] int  NOT NULL,
    [SuperficieTerrain] int  NOT NULL,
    [NbPieceLogement] smallint  NOT NULL,
    [NbHabitantRestant] smallint  NOT NULL,
    [NbColocRecherche] smallint  NOT NULL,
    [AccesHandicape] bit  NOT NULL,
    [AccesTransportCommun] bit  NOT NULL,
    [InfoSupAccessibilite] nvarchar(100)  NULL,
    [ConsoAlcoolTolerence] bit  NOT NULL,
    [FumeurTolerence] bit  NOT NULL,
    [AnimauxTolerence] bit  NOT NULL,
    [InfoSupTolerence] nvarchar(100)  NULL,
    [DatePublication] datetime  NOT NULL,
    [Activation] bit  NOT NULL
);
GO

-- Creating table 'ChambreLocation'
CREATE TABLE [dbo].[ChambreLocation] (
    [IdChambreLocation] int IDENTITY(1,1) NOT NULL,
    [IdAnnonceLocation] int  NOT NULL,
    [Loyer] int  NOT NULL,
    [Charges] int  NOT NULL,
    [DetailCharges] nvarchar(100)  NOT NULL,
    [Caution] int  NULL,
    [Superficie] int  NOT NULL,
    [Meublee] bit  NOT NULL,
    [DateDisponibilite] datetime  NOT NULL,
    [DateFinDisponibilite] datetime  NULL
);
GO

-- Creating table 'ProjetCreation'
CREATE TABLE [dbo].[ProjetCreation] (
    [IdProjetCreation] int IDENTITY(1,1) NOT NULL,
    [IdUtilisateur] int  NOT NULL,
    [Introduction] nvarchar(100)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EngagementTerrain] tinyint  NULL,
    [SuperficieMaxTerrain] int  NULL,
    [CoutAchatMaxTerrain] int  NULL,
    [EngagementLogement] tinyint  NOT NULL,
    [TypeHabitat] tinyint  NOT NULL,
    [ImplantationLogement] tinyint  NOT NULL,
    [SuperficieMaxLogement] int  NOT NULL,
    [CoutAchatMaxLogement] int  NULL,
    [LoyerMaxLogement] int  NULL,
    [CoutConstructionMaxLogement] int  NULL,
    [NbPersoTotal] smallint  NOT NULL,
    [NbPersAchatTerrain] smallint  NULL,
    [NbPersAchatLogement] smallint  NULL,
    [NbPersLocationLogement] smallint  NULL,
    [AccesTransportCommun] tinyint  NOT NULL,
    [InfoSupAccessibilite] nvarchar(100)  NULL,
    [ConsoAlcoolTolerence] bit  NOT NULL,
    [FumeurTolerence] bit  NOT NULL,
    [AnimauxTolerence] bit  NOT NULL,
    [InfoSupTolerence] nvarchar(100)  NULL,
    [DescriptionPersonnalite] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Lieu'
CREATE TABLE [dbo].[Lieu] (
    [IdLieu] int IDENTITY(1,1) NOT NULL,
    [Ville] nvarchar(50)  NOT NULL,
    [CodePostal] nvarchar(15)  NOT NULL,
    [Departement] nvarchar(50)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [Pays] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Evenement'
CREATE TABLE [dbo].[Evenement] (
    [IdEvenement] int IDENTITY(1,1) NOT NULL,
    [IdUtilisateur] int  NOT NULL,
    [NomImage] nvarchar(50)  NULL,
    [DateDebut] datetime  NOT NULL,
    [DateFin] datetime  NOT NULL,
    [NumRue] nvarchar(10)  NOT NULL,
    [Rue] nvarchar(80)  NOT NULL,
    [Ville] nvarchar(60)  NOT NULL,
    [CodePostal] nvarchar(15)  NOT NULL,
    [Departement] nvarchar(50)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [Pays] nvarchar(50)  NOT NULL,
    [Lien] nvarchar(500)  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DatePublication] datetime  NULL
);
GO

-- Creating table 'EvenementPresence'
CREATE TABLE [dbo].[EvenementPresence] (
    [IdUtilisateur] int  NOT NULL,
    [IdEvenement] int  NOT NULL,
    [Statut] tinyint  NOT NULL
);
GO

-- Creating table 'EcoColocExistante'
CREATE TABLE [dbo].[EcoColocExistante] (
    [IdEcoColocExistante] int IDENTITY(1,1) NOT NULL,
    [NomEcoColoc] nvarchar(50)  NOT NULL,
    [NbColocataire] int  NOT NULL,
    [Pays] nvarchar(50)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [Departement] nvarchar(50)  NOT NULL,
    [Ville] nvarchar(50)  NOT NULL,
    [CodePostal] nvarchar(15)  NOT NULL,
    [Email] nvarchar(60)  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ImplicationEcologique] tinyint  NOT NULL,
    [TableauEcolo] nvarchar(max)  NOT NULL,
    [TableauHabitat] nvarchar(max)  NOT NULL,
    [Utilisateur_IdUtilisateur] int  NOT NULL
);
GO

-- Creating table 'ImageConversationDev'
CREATE TABLE [dbo].[ImageConversationDev] (
    [IdImgConversationDev] int IDENTITY(1,1) NOT NULL,
    [IdConversationDev] int  NOT NULL,
    [NomImage] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Colocataire'
CREATE TABLE [dbo].[Colocataire] (
    [IdColocataire] int IDENTITY(1,1) NOT NULL,
    [Prenom] nvarchar(50)  NOT NULL,
    [Nom] nvarchar(50)  NOT NULL,
    [Email] nvarchar(60)  NOT NULL,
    [DateNaissance] nvarchar(10)  NOT NULL,
    [Civilite] tinyint  NOT NULL,
    [EcoColocExistante_IdEcoColocExistante] int  NOT NULL
);
GO

-- Creating table 'ConversationDev'
CREATE TABLE [dbo].[ConversationDev] (
    [IdConversationDev] int IDENTITY(1,1) NOT NULL,
    [Message] nvarchar(max)  NOT NULL,
    [DateDernierEnvoi] datetime  NOT NULL,
    [Utilisateur_IdUtilisateur] int  NOT NULL
);
GO

-- Creating table 'RechercheColocation'
CREATE TABLE [dbo].[RechercheColocation] (
    [IdRechercheColocation] int IDENTITY(1,1) NOT NULL,
    [DescriptionPersonnalite] nvarchar(500)  NOT NULL,
    [CritereRecherche] nvarchar(max)  NOT NULL,
    [PratiqueEcolo] nvarchar(max)  NOT NULL,
    [NomPhoto] nvarchar(50)  NOT NULL,
    [Utilisateur_IdUtilisateur] int  NOT NULL
);
GO

-- Creating table 'Role'
CREATE TABLE [dbo].[Role] (
    [IdRole] int IDENTITY(1,1) NOT NULL,
    [NomRole] nvarchar(50)  NOT NULL,
    [Description] nvarchar(100)  NULL
);
GO

-- Creating table 'Utilisateur'
CREATE TABLE [dbo].[Utilisateur] (
    [IdUtilisateur] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(60)  NOT NULL,
    [Prenom] nvarchar(50)  NOT NULL,
    [Nom] nvarchar(50)  NOT NULL,
    [Civilite] tinyint  NOT NULL,
    [Pays] nvarchar(50)  NOT NULL,
    [DateNaissance] nvarchar(10)  NOT NULL,
    [Activite] tinyint  NULL,
    [CodeTelPays] nvarchar(15)  NOT NULL,
    [Telephone] nvarchar(12)  NOT NULL,
    [TypeContact] tinyint  NOT NULL,
    [DateInscription] datetime  NOT NULL,
    [DateDerniereActivite] datetime  NOT NULL,
    [Activation] bit  NOT NULL
);
GO

-- Creating table 'EvenementAssocie'
CREATE TABLE [dbo].[EvenementAssocie] (
    [IdEvenement] int  NOT NULL,
    [IdEvenementAssocie] int  NOT NULL
);
GO

-- Creating table 'Adhesion'
CREATE TABLE [dbo].[Adhesion] (
    [IdAdhesion] int IDENTITY(1,1) NOT NULL,
    [MotDePasse] nvarchar(50)  NOT NULL,
    [DateCreation] datetime  NOT NULL,
    [Utilisateur_IdUtilisateur] int  NOT NULL
);
GO

-- Creating table 'ImageEcoColocEx'
CREATE TABLE [dbo].[ImageEcoColocEx] (
    [IdImageEcoColocEx] int IDENTITY(1,1) NOT NULL,
    [IdEcoColocExistante] int  NOT NULL,
    [NomImage] nvarchar(50)  NOT NULL,
    [NumOrdre] tinyint  NOT NULL
);
GO

-- Creating table 'ImageProjetCreation'
CREATE TABLE [dbo].[ImageProjetCreation] (
    [IdImgProjetCreation] int IDENTITY(1,1) NOT NULL,
    [NomImage] nvarchar(50)  NOT NULL,
    [NumOrdre] tinyint  NOT NULL,
    [ProjetCreation_IdProjetCreation] int  NOT NULL
);
GO

-- Creating table 'ProjetCreation_Lieu'
CREATE TABLE [dbo].[ProjetCreation_Lieu] (
    [ProjetCreation_IdProjetCreation] int  NOT NULL,
    [Lieu_IdLieu] int  NOT NULL
);
GO

-- Creating table 'Lieu_RechercheColoc'
CREATE TABLE [dbo].[Lieu_RechercheColoc] (
    [RechercheColocation_IdRechercheColocation] int  NOT NULL,
    [Lieu_IdLieu] int  NOT NULL
);
GO

-- Creating table 'Utilisateur_Role'
CREATE TABLE [dbo].[Utilisateur_Role] (
    [Utilisateur_IdUtilisateur] int  NOT NULL,
    [Role_IdRole] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAnnonceLocation] in table 'AnnonceLocation'
ALTER TABLE [dbo].[AnnonceLocation]
ADD CONSTRAINT [PK_AnnonceLocation]
    PRIMARY KEY CLUSTERED ([IdAnnonceLocation] ASC);
GO

-- Creating primary key on [IdChambreLocation] in table 'ChambreLocation'
ALTER TABLE [dbo].[ChambreLocation]
ADD CONSTRAINT [PK_ChambreLocation]
    PRIMARY KEY CLUSTERED ([IdChambreLocation] ASC);
GO

-- Creating primary key on [IdProjetCreation] in table 'ProjetCreation'
ALTER TABLE [dbo].[ProjetCreation]
ADD CONSTRAINT [PK_ProjetCreation]
    PRIMARY KEY CLUSTERED ([IdProjetCreation] ASC);
GO

-- Creating primary key on [IdLieu] in table 'Lieu'
ALTER TABLE [dbo].[Lieu]
ADD CONSTRAINT [PK_Lieu]
    PRIMARY KEY CLUSTERED ([IdLieu] ASC);
GO

-- Creating primary key on [IdEvenement] in table 'Evenement'
ALTER TABLE [dbo].[Evenement]
ADD CONSTRAINT [PK_Evenement]
    PRIMARY KEY CLUSTERED ([IdEvenement] ASC);
GO

-- Creating primary key on [IdUtilisateur], [IdEvenement] in table 'EvenementPresence'
ALTER TABLE [dbo].[EvenementPresence]
ADD CONSTRAINT [PK_EvenementPresence]
    PRIMARY KEY CLUSTERED ([IdUtilisateur], [IdEvenement] ASC);
GO

-- Creating primary key on [IdEcoColocExistante] in table 'EcoColocExistante'
ALTER TABLE [dbo].[EcoColocExistante]
ADD CONSTRAINT [PK_EcoColocExistante]
    PRIMARY KEY CLUSTERED ([IdEcoColocExistante] ASC);
GO

-- Creating primary key on [IdImgConversationDev] in table 'ImageConversationDev'
ALTER TABLE [dbo].[ImageConversationDev]
ADD CONSTRAINT [PK_ImageConversationDev]
    PRIMARY KEY CLUSTERED ([IdImgConversationDev] ASC);
GO

-- Creating primary key on [IdColocataire] in table 'Colocataire'
ALTER TABLE [dbo].[Colocataire]
ADD CONSTRAINT [PK_Colocataire]
    PRIMARY KEY CLUSTERED ([IdColocataire] ASC);
GO

-- Creating primary key on [IdConversationDev] in table 'ConversationDev'
ALTER TABLE [dbo].[ConversationDev]
ADD CONSTRAINT [PK_ConversationDev]
    PRIMARY KEY CLUSTERED ([IdConversationDev] ASC);
GO

-- Creating primary key on [IdRechercheColocation] in table 'RechercheColocation'
ALTER TABLE [dbo].[RechercheColocation]
ADD CONSTRAINT [PK_RechercheColocation]
    PRIMARY KEY CLUSTERED ([IdRechercheColocation] ASC);
GO

-- Creating primary key on [IdRole] in table 'Role'
ALTER TABLE [dbo].[Role]
ADD CONSTRAINT [PK_Role]
    PRIMARY KEY CLUSTERED ([IdRole] ASC);
GO

-- Creating primary key on [IdUtilisateur] in table 'Utilisateur'
ALTER TABLE [dbo].[Utilisateur]
ADD CONSTRAINT [PK_Utilisateur]
    PRIMARY KEY CLUSTERED ([IdUtilisateur] ASC);
GO

-- Creating primary key on [IdEvenement], [IdEvenementAssocie] in table 'EvenementAssocie'
ALTER TABLE [dbo].[EvenementAssocie]
ADD CONSTRAINT [PK_EvenementAssocie]
    PRIMARY KEY CLUSTERED ([IdEvenement], [IdEvenementAssocie] ASC);
GO

-- Creating primary key on [IdAdhesion] in table 'Adhesion'
ALTER TABLE [dbo].[Adhesion]
ADD CONSTRAINT [PK_Adhesion]
    PRIMARY KEY CLUSTERED ([IdAdhesion] ASC);
GO

-- Creating primary key on [IdImageEcoColocEx] in table 'ImageEcoColocEx'
ALTER TABLE [dbo].[ImageEcoColocEx]
ADD CONSTRAINT [PK_ImageEcoColocEx]
    PRIMARY KEY CLUSTERED ([IdImageEcoColocEx] ASC);
GO

-- Creating primary key on [IdImgProjetCreation] in table 'ImageProjetCreation'
ALTER TABLE [dbo].[ImageProjetCreation]
ADD CONSTRAINT [PK_ImageProjetCreation]
    PRIMARY KEY CLUSTERED ([IdImgProjetCreation] ASC);
GO

-- Creating primary key on [ProjetCreation_IdProjetCreation], [Lieu_IdLieu] in table 'ProjetCreation_Lieu'
ALTER TABLE [dbo].[ProjetCreation_Lieu]
ADD CONSTRAINT [PK_ProjetCreation_Lieu]
    PRIMARY KEY CLUSTERED ([ProjetCreation_IdProjetCreation], [Lieu_IdLieu] ASC);
GO

-- Creating primary key on [RechercheColocation_IdRechercheColocation], [Lieu_IdLieu] in table 'Lieu_RechercheColoc'
ALTER TABLE [dbo].[Lieu_RechercheColoc]
ADD CONSTRAINT [PK_Lieu_RechercheColoc]
    PRIMARY KEY CLUSTERED ([RechercheColocation_IdRechercheColocation], [Lieu_IdLieu] ASC);
GO

-- Creating primary key on [Utilisateur_IdUtilisateur], [Role_IdRole] in table 'Utilisateur_Role'
ALTER TABLE [dbo].[Utilisateur_Role]
ADD CONSTRAINT [PK_Utilisateur_Role]
    PRIMARY KEY CLUSTERED ([Utilisateur_IdUtilisateur], [Role_IdRole] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdAnnonceLocation] in table 'ChambreLocation'
ALTER TABLE [dbo].[ChambreLocation]
ADD CONSTRAINT [FK_Location_ChambreLocation]
    FOREIGN KEY ([IdAnnonceLocation])
    REFERENCES [dbo].[AnnonceLocation]
        ([IdAnnonceLocation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Location_ChambreLocation'
CREATE INDEX [IX_FK_Location_ChambreLocation]
ON [dbo].[ChambreLocation]
    ([IdAnnonceLocation]);
GO

-- Creating foreign key on [ProjetCreation_IdProjetCreation] in table 'ProjetCreation_Lieu'
ALTER TABLE [dbo].[ProjetCreation_Lieu]
ADD CONSTRAINT [FK_ProjetCreation_Lieu_ProjetCreation]
    FOREIGN KEY ([ProjetCreation_IdProjetCreation])
    REFERENCES [dbo].[ProjetCreation]
        ([IdProjetCreation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Lieu_IdLieu] in table 'ProjetCreation_Lieu'
ALTER TABLE [dbo].[ProjetCreation_Lieu]
ADD CONSTRAINT [FK_ProjetCreation_Lieu_Lieu]
    FOREIGN KEY ([Lieu_IdLieu])
    REFERENCES [dbo].[Lieu]
        ([IdLieu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetCreation_Lieu_Lieu'
CREATE INDEX [IX_FK_ProjetCreation_Lieu_Lieu]
ON [dbo].[ProjetCreation_Lieu]
    ([Lieu_IdLieu]);
GO

-- Creating foreign key on [RechercheColocation_IdRechercheColocation] in table 'Lieu_RechercheColoc'
ALTER TABLE [dbo].[Lieu_RechercheColoc]
ADD CONSTRAINT [FK_Lieu_RechercheColoc_RechercheColoc]
    FOREIGN KEY ([RechercheColocation_IdRechercheColocation])
    REFERENCES [dbo].[RechercheColocation]
        ([IdRechercheColocation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Lieu_IdLieu] in table 'Lieu_RechercheColoc'
ALTER TABLE [dbo].[Lieu_RechercheColoc]
ADD CONSTRAINT [FK_Lieu_RechercheColoc_Lieu]
    FOREIGN KEY ([Lieu_IdLieu])
    REFERENCES [dbo].[Lieu]
        ([IdLieu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Lieu_RechercheColoc_Lieu'
CREATE INDEX [IX_FK_Lieu_RechercheColoc_Lieu]
ON [dbo].[Lieu_RechercheColoc]
    ([Lieu_IdLieu]);
GO

-- Creating foreign key on [Utilisateur_IdUtilisateur] in table 'Utilisateur_Role'
ALTER TABLE [dbo].[Utilisateur_Role]
ADD CONSTRAINT [FK_Utilisateur_Role_Utilisateur]
    FOREIGN KEY ([Utilisateur_IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Role_IdRole] in table 'Utilisateur_Role'
ALTER TABLE [dbo].[Utilisateur_Role]
ADD CONSTRAINT [FK_Utilisateur_Role_Role]
    FOREIGN KEY ([Role_IdRole])
    REFERENCES [dbo].[Role]
        ([IdRole])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Utilisateur_Role_Role'
CREATE INDEX [IX_FK_Utilisateur_Role_Role]
ON [dbo].[Utilisateur_Role]
    ([Role_IdRole]);
GO

-- Creating foreign key on [IdUtilisateur] in table 'ProjetCreation'
ALTER TABLE [dbo].[ProjetCreation]
ADD CONSTRAINT [FK_Utilisateur_ProjetCreation]
    FOREIGN KEY ([IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Utilisateur_ProjetCreation'
CREATE INDEX [IX_FK_Utilisateur_ProjetCreation]
ON [dbo].[ProjetCreation]
    ([IdUtilisateur]);
GO

-- Creating foreign key on [IdUtilisateur] in table 'AnnonceLocation'
ALTER TABLE [dbo].[AnnonceLocation]
ADD CONSTRAINT [FK_Utilisateur_Location]
    FOREIGN KEY ([IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Utilisateur_Location'
CREATE INDEX [IX_FK_Utilisateur_Location]
ON [dbo].[AnnonceLocation]
    ([IdUtilisateur]);
GO

-- Creating foreign key on [IdUtilisateur] in table 'EvenementPresence'
ALTER TABLE [dbo].[EvenementPresence]
ADD CONSTRAINT [FK_Utilisateur_EvenementPresence]
    FOREIGN KEY ([IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEvenement] in table 'EvenementPresence'
ALTER TABLE [dbo].[EvenementPresence]
ADD CONSTRAINT [FK_Evenement_EvenementPresence]
    FOREIGN KEY ([IdEvenement])
    REFERENCES [dbo].[Evenement]
        ([IdEvenement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Evenement_EvenementPresence'
CREATE INDEX [IX_FK_Evenement_EvenementPresence]
ON [dbo].[EvenementPresence]
    ([IdEvenement]);
GO

-- Creating foreign key on [IdEvenement] in table 'EvenementAssocie'
ALTER TABLE [dbo].[EvenementAssocie]
ADD CONSTRAINT [FK_Evenement_EvenementAssocie]
    FOREIGN KEY ([IdEvenement])
    REFERENCES [dbo].[Evenement]
        ([IdEvenement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEvenementAssocie] in table 'EvenementAssocie'
ALTER TABLE [dbo].[EvenementAssocie]
ADD CONSTRAINT [FK_Evenement_EvenementAssocie1]
    FOREIGN KEY ([IdEvenementAssocie])
    REFERENCES [dbo].[Evenement]
        ([IdEvenement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Evenement_EvenementAssocie1'
CREATE INDEX [IX_FK_Evenement_EvenementAssocie1]
ON [dbo].[EvenementAssocie]
    ([IdEvenementAssocie]);
GO

-- Creating foreign key on [IdConversationDev] in table 'ImageConversationDev'
ALTER TABLE [dbo].[ImageConversationDev]
ADD CONSTRAINT [FK_ConversationDev_ImageConversationDev]
    FOREIGN KEY ([IdConversationDev])
    REFERENCES [dbo].[ConversationDev]
        ([IdConversationDev])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConversationDev_ImageConversationDev'
CREATE INDEX [IX_FK_ConversationDev_ImageConversationDev]
ON [dbo].[ImageConversationDev]
    ([IdConversationDev]);
GO

-- Creating foreign key on [Utilisateur_IdUtilisateur] in table 'Adhesion'
ALTER TABLE [dbo].[Adhesion]
ADD CONSTRAINT [FK_Adhesion_Utilisateur]
    FOREIGN KEY ([Utilisateur_IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Adhesion_Utilisateur'
CREATE INDEX [IX_FK_Adhesion_Utilisateur]
ON [dbo].[Adhesion]
    ([Utilisateur_IdUtilisateur]);
GO

-- Creating foreign key on [IdEcoColocExistante] in table 'ImageEcoColocEx'
ALTER TABLE [dbo].[ImageEcoColocEx]
ADD CONSTRAINT [FK_EcoColocExistante_ImageEcoColocEx]
    FOREIGN KEY ([IdEcoColocExistante])
    REFERENCES [dbo].[EcoColocExistante]
        ([IdEcoColocExistante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EcoColocExistante_ImageEcoColocEx'
CREATE INDEX [IX_FK_EcoColocExistante_ImageEcoColocEx]
ON [dbo].[ImageEcoColocEx]
    ([IdEcoColocExistante]);
GO

-- Creating foreign key on [IdUtilisateur] in table 'Evenement'
ALTER TABLE [dbo].[Evenement]
ADD CONSTRAINT [FK_Utilisateur_Evenement]
    FOREIGN KEY ([IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Utilisateur_Evenement'
CREATE INDEX [IX_FK_Utilisateur_Evenement]
ON [dbo].[Evenement]
    ([IdUtilisateur]);
GO

-- Creating foreign key on [Utilisateur_IdUtilisateur] in table 'ConversationDev'
ALTER TABLE [dbo].[ConversationDev]
ADD CONSTRAINT [FK_ConversationDev_Utilisateur]
    FOREIGN KEY ([Utilisateur_IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConversationDev_Utilisateur'
CREATE INDEX [IX_FK_ConversationDev_Utilisateur]
ON [dbo].[ConversationDev]
    ([Utilisateur_IdUtilisateur]);
GO

-- Creating foreign key on [EcoColocExistante_IdEcoColocExistante] in table 'Colocataire'
ALTER TABLE [dbo].[Colocataire]
ADD CONSTRAINT [FK_Colocataire_EcoColocExistante]
    FOREIGN KEY ([EcoColocExistante_IdEcoColocExistante])
    REFERENCES [dbo].[EcoColocExistante]
        ([IdEcoColocExistante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Colocataire_EcoColocExistante'
CREATE INDEX [IX_FK_Colocataire_EcoColocExistante]
ON [dbo].[Colocataire]
    ([EcoColocExistante_IdEcoColocExistante]);
GO

-- Creating foreign key on [ProjetCreation_IdProjetCreation] in table 'ImageProjetCreation'
ALTER TABLE [dbo].[ImageProjetCreation]
ADD CONSTRAINT [FK_ImageProjetCreation_ProjetCreation]
    FOREIGN KEY ([ProjetCreation_IdProjetCreation])
    REFERENCES [dbo].[ProjetCreation]
        ([IdProjetCreation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImageProjetCreation_ProjetCreation'
CREATE INDEX [IX_FK_ImageProjetCreation_ProjetCreation]
ON [dbo].[ImageProjetCreation]
    ([ProjetCreation_IdProjetCreation]);
GO

-- Creating foreign key on [Utilisateur_IdUtilisateur] in table 'RechercheColocation'
ALTER TABLE [dbo].[RechercheColocation]
ADD CONSTRAINT [FK_RechercheColocation_Utilisateur]
    FOREIGN KEY ([Utilisateur_IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RechercheColocation_Utilisateur'
CREATE INDEX [IX_FK_RechercheColocation_Utilisateur]
ON [dbo].[RechercheColocation]
    ([Utilisateur_IdUtilisateur]);
GO

-- Creating foreign key on [Utilisateur_IdUtilisateur] in table 'EcoColocExistante'
ALTER TABLE [dbo].[EcoColocExistante]
ADD CONSTRAINT [FK_EcoColocExistante_Utilisateur]
    FOREIGN KEY ([Utilisateur_IdUtilisateur])
    REFERENCES [dbo].[Utilisateur]
        ([IdUtilisateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EcoColocExistante_Utilisateur'
CREATE INDEX [IX_FK_EcoColocExistante_Utilisateur]
ON [dbo].[EcoColocExistante]
    ([Utilisateur_IdUtilisateur]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------