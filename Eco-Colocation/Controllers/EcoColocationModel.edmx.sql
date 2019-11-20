
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/20/2019 16:26:26
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

IF OBJECT_ID(N'[dbo].[FK_LocationChambreLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ChambreLocationSet] DROP CONSTRAINT [FK_LocationChambreLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetCreationLieuProjetCreation_ProjetCreation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetCreationLieuProjetCreation] DROP CONSTRAINT [FK_ProjetCreationLieuProjetCreation_ProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetCreationLieuProjetCreation_LieuProjetCreation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetCreationLieuProjetCreation] DROP CONSTRAINT [FK_ProjetCreationLieuProjetCreation_LieuProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[FK_EcoColocExistanteColocataire]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColocataireSet] DROP CONSTRAINT [FK_EcoColocExistanteColocataire];
GO
IF OBJECT_ID(N'[dbo].[FK_EcoColocExistanteEcoColocImage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageSet] DROP CONSTRAINT [FK_EcoColocExistanteEcoColocImage];
GO
IF OBJECT_ID(N'[dbo].[FK_EvenementEvenementPublication]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementPublicationSet] DROP CONSTRAINT [FK_EvenementEvenementPublication];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonneEnRechercheLieu_PersonneEnRecherche]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonneEnRechercheLieu] DROP CONSTRAINT [FK_PersonneEnRechercheLieu_PersonneEnRecherche];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonneEnRechercheLieu_Lieu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonneEnRechercheLieu] DROP CONSTRAINT [FK_PersonneEnRechercheLieu_Lieu];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_Userswebpages_Roles_webpages_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_Userswebpages_Roles] DROP CONSTRAINT [FK_webpages_Userswebpages_Roles_webpages_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_Userswebpages_Roles_webpages_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_Userswebpages_Roles] DROP CONSTRAINT [FK_webpages_Userswebpages_Roles_webpages_Roles];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_Userswebpages_Membership]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_MembershipSet] DROP CONSTRAINT [FK_webpages_Userswebpages_Membership];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_UsersProjetCreation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnnonceProjetCreationSet] DROP CONSTRAINT [FK_webpages_UsersProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_UsersLocation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AnnonceLocationSet] DROP CONSTRAINT [FK_webpages_UsersLocation];
GO
IF OBJECT_ID(N'[dbo].[FK_AnnonceProjetCreationImage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageSet] DROP CONSTRAINT [FK_AnnonceProjetCreationImage];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_UsersEvenementPresence]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementPresenceSet] DROP CONSTRAINT [FK_webpages_UsersEvenementPresence];
GO
IF OBJECT_ID(N'[dbo].[FK_EvenementEvenementPresence]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementPresenceSet] DROP CONSTRAINT [FK_EvenementEvenementPresence];
GO
IF OBJECT_ID(N'[dbo].[FK_EvenementEvenementAssocie]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementAssocieSet] DROP CONSTRAINT [FK_EvenementEvenementAssocie];
GO
IF OBJECT_ID(N'[dbo].[FK_EvenementEvenementAssocie1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EvenementAssocieSet] DROP CONSTRAINT [FK_EvenementEvenementAssocie1];
GO
IF OBJECT_ID(N'[dbo].[FK_ConversationDevImage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageSet] DROP CONSTRAINT [FK_ConversationDevImage];
GO
IF OBJECT_ID(N'[dbo].[FK_RechercheColocationwebpages_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RechercheColocationSet] DROP CONSTRAINT [FK_RechercheColocationwebpages_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_UsersEcoColocExistante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_UsersSet] DROP CONSTRAINT [FK_webpages_UsersEcoColocExistante];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AnnonceLocationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnnonceLocationSet];
GO
IF OBJECT_ID(N'[dbo].[ChambreLocationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ChambreLocationSet];
GO
IF OBJECT_ID(N'[dbo].[AnnonceProjetCreationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AnnonceProjetCreationSet];
GO
IF OBJECT_ID(N'[dbo].[LieuSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LieuSet];
GO
IF OBJECT_ID(N'[dbo].[EvenementSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvenementSet];
GO
IF OBJECT_ID(N'[dbo].[EvenementPresenceSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvenementPresenceSet];
GO
IF OBJECT_ID(N'[dbo].[EvenementPublicationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvenementPublicationSet];
GO
IF OBJECT_ID(N'[dbo].[EcoColocExistanteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EcoColocExistanteSet];
GO
IF OBJECT_ID(N'[dbo].[ImageSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImageSet];
GO
IF OBJECT_ID(N'[dbo].[ColocataireSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ColocataireSet];
GO
IF OBJECT_ID(N'[dbo].[ConversationDevSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConversationDevSet];
GO
IF OBJECT_ID(N'[dbo].[RechercheColocationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RechercheColocationSet];
GO
IF OBJECT_ID(N'[dbo].[webpages_MembershipSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_MembershipSet];
GO
IF OBJECT_ID(N'[dbo].[webpages_RolesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_RolesSet];
GO
IF OBJECT_ID(N'[dbo].[webpages_UsersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_UsersSet];
GO
IF OBJECT_ID(N'[dbo].[EvenementAssocieSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EvenementAssocieSet];
GO
IF OBJECT_ID(N'[dbo].[ProjetCreationLieuProjetCreation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjetCreationLieuProjetCreation];
GO
IF OBJECT_ID(N'[dbo].[PersonneEnRechercheLieu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonneEnRechercheLieu];
GO
IF OBJECT_ID(N'[dbo].[webpages_Userswebpages_Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_Userswebpages_Roles];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AnnonceLocationSet'
CREATE TABLE [dbo].[AnnonceLocationSet] (
    [IdAnnonceLocation] int IDENTITY(1,1) NOT NULL,
    [Introduction] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Rue] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [CodePostal] nvarchar(max)  NOT NULL,
    [Departement] nvarchar(max)  NOT NULL,
    [Region] nvarchar(max)  NOT NULL,
    [Pays] nvarchar(max)  NOT NULL,
    [Latitude] nvarchar(max)  NOT NULL,
    [Longitude] nvarchar(max)  NOT NULL,
    [TypeLogement] tinyint  NOT NULL,
    [ImplantationLogement] tinyint  NOT NULL,
    [SuperficieLogement] int  NOT NULL,
    [SuperficieTerrain] int  NOT NULL,
    [NbPieceLogement] smallint  NOT NULL,
    [NbHabitantRestant] smallint  NOT NULL,
    [NbColocRecherche] smallint  NOT NULL,
    [AccesHandicape] bit  NOT NULL,
    [AccesTransportCommun] bit  NOT NULL,
    [InfoSupAccessibilite] nvarchar(max)  NULL,
    [ConsoAlcoolTolerence] bit  NOT NULL,
    [FumeurTolerence] bit  NOT NULL,
    [AnimauxTolerence] bit  NOT NULL,
    [InfoSupTolerence] nvarchar(max)  NULL,
    [DatePublication] datetime  NOT NULL,
    [StatutAnnonce] bit  NOT NULL,
    [UsersId] int  NOT NULL
);
GO

-- Creating table 'ChambreLocationSet'
CREATE TABLE [dbo].[ChambreLocationSet] (
    [IdChambreLocation] int IDENTITY(1,1) NOT NULL,
    [IdAnnonceLocation] int  NOT NULL,
    [Loyer] int  NOT NULL,
    [Charges] int  NOT NULL,
    [DetailCharges] nvarchar(max)  NOT NULL,
    [Caution] int  NULL,
    [Superficie] int  NOT NULL,
    [Meublee] bit  NOT NULL,
    [DateDisponibilite] datetime  NOT NULL,
    [DateFinDisponibilite] datetime  NULL
);
GO

-- Creating table 'AnnonceProjetCreationSet'
CREATE TABLE [dbo].[AnnonceProjetCreationSet] (
    [IdAnnonceProjetCreation] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EngagementTerrain] tinyint  NOT NULL,
    [SuperficieMaxTerrain] int  NOT NULL,
    [EngagementLogement] tinyint  NOT NULL,
    [TypeHabitat] tinyint  NOT NULL,
    [ImplantationLogement] tinyint  NOT NULL,
    [SuperficieMaxLogement] int  NOT NULL,
    [CoutAchatMaxLogement] int  NOT NULL,
    [LoyerMaxLogement] int  NOT NULL,
    [CoutConstructionLogement] int  NOT NULL,
    [AccesHandicape] bit  NOT NULL,
    [NbPersoTotal] int  NOT NULL,
    [NbPersAchatTerrain] int  NOT NULL,
    [NbPersLocationLogement] int  NOT NULL,
    [AccesTransportCommun] bit  NOT NULL,
    [InfoSupAccessibilite] nvarchar(max)  NULL,
    [ConsoAlcoolTolerence] bit  NOT NULL,
    [FumeurTolerence] bit  NOT NULL,
    [AnimauxTolerence] bit  NOT NULL,
    [InfoSupTolerence] nvarchar(max)  NULL,
    [DescriptionPersonnalite] nvarchar(max)  NOT NULL,
    [IdUsers] int  NOT NULL
);
GO

-- Creating table 'LieuSet'
CREATE TABLE [dbo].[LieuSet] (
    [IdLieu] int IDENTITY(1,1) NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [CodePostal] nvarchar(max)  NOT NULL,
    [Departement] nvarchar(max)  NOT NULL,
    [Region] nvarchar(max)  NOT NULL,
    [Pays] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EvenementSet'
CREATE TABLE [dbo].[EvenementSet] (
    [IdEvenement] int IDENTITY(1,1) NOT NULL,
    [DateDebut] datetime  NOT NULL,
    [Pays] nvarchar(max)  NOT NULL,
    [Region] nvarchar(max)  NOT NULL,
    [Departement] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [CodePostal] int  NOT NULL,
    [NumRue] nvarchar(max)  NOT NULL,
    [Lien] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [NomImage] nvarchar(max)  NULL,
    [webpages_UsersIdUsers] int  NOT NULL
);
GO

-- Creating table 'EvenementPresenceSet'
CREATE TABLE [dbo].[EvenementPresenceSet] (
    [IdEvenementPresence] int IDENTITY(1,1) NOT NULL,
    [Statut] tinyint  NOT NULL,
    [IdUser] int  NOT NULL,
    [IdEvenement] int  NOT NULL
);
GO

-- Creating table 'EvenementPublicationSet'
CREATE TABLE [dbo].[EvenementPublicationSet] (
    [IdPublication] int IDENTITY(1,1) NOT NULL,
    [IdEvenement] int  NOT NULL,
    [DatePublication] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EcoColocExistanteSet'
CREATE TABLE [dbo].[EcoColocExistanteSet] (
    [IdEcoColocExistante] int IDENTITY(1,1) NOT NULL,
    [NomEcoColoc] nvarchar(max)  NOT NULL,
    [NbColocataire] int  NOT NULL,
    [Pays] nvarchar(max)  NOT NULL,
    [Region] nvarchar(max)  NOT NULL,
    [Departement] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [CodePostal] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ImplicationEcologique] tinyint  NOT NULL,
    [TableauEcolo] nvarchar(max)  NOT NULL,
    [TableauHabitat] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ImageSet'
CREATE TABLE [dbo].[ImageSet] (
    [IdEcoColocImage] int IDENTITY(1,1) NOT NULL,
    [IdEcoColocExistante] int  NOT NULL,
    [IdAnnonceProjetCreation] int  NOT NULL,
    [IdConversationDev] int  NOT NULL,
    [NomImage] nvarchar(max)  NOT NULL,
    [Numero] tinyint  NOT NULL
);
GO

-- Creating table 'ColocataireSet'
CREATE TABLE [dbo].[ColocataireSet] (
    [IdColocataire] int IDENTITY(1,1) NOT NULL,
    [IdEcoColocExistante] int  NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [DateNaissance] nvarchar(max)  NOT NULL,
    [Civilite] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ConversationDevSet'
CREATE TABLE [dbo].[ConversationDevSet] (
    [IdConversationDev] int IDENTITY(1,1) NOT NULL,
    [Message] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'RechercheColocationSet'
CREATE TABLE [dbo].[RechercheColocationSet] (
    [IdRechercheColocation] int IDENTITY(1,1) NOT NULL,
    [DescriptionPersonnalite] nvarchar(max)  NOT NULL,
    [CritereRecherche] nvarchar(max)  NOT NULL,
    [PratiqueEcolo] nvarchar(max)  NOT NULL,
    [NomPhoto] nvarchar(max)  NOT NULL,
    [webpages_Users_UsersId] int  NOT NULL
);
GO

-- Creating table 'webpages_MembershipSet'
CREATE TABLE [dbo].[webpages_MembershipSet] (
    [CreateDate] int IDENTITY(1,1) NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [UsersId] int  NOT NULL
);
GO

-- Creating table 'webpages_RolesSet'
CREATE TABLE [dbo].[webpages_RolesSet] (
    [IdRole] int IDENTITY(1,1) NOT NULL,
    [RoleName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'webpages_UsersSet'
CREATE TABLE [dbo].[webpages_UsersSet] (
    [UsersId] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Civilite] tinyint  NOT NULL,
    [Pays] nvarchar(max)  NOT NULL,
    [DateNaissance] nvarchar(max)  NOT NULL,
    [Activites] tinyint  NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [TypeContact] tinyint  NOT NULL,
    [DateInscription] datetime  NOT NULL,
    [Activited] bit  NOT NULL,
    [webpages_UsersEcoColocExistante_webpages_Users_IdEcoColocExistante] int  NOT NULL
);
GO

-- Creating table 'EvenementAssocieSet'
CREATE TABLE [dbo].[EvenementAssocieSet] (
    [IdEvenementAssocie] int IDENTITY(1,1) NOT NULL,
    [IdEvenement] int  NOT NULL,
    [IdEvenementLink] int  NOT NULL
);
GO

-- Creating table 'ProjetCreationLieuProjetCreation'
CREATE TABLE [dbo].[ProjetCreationLieuProjetCreation] (
    [AnnonceProjetCreation_IdAnnonceProjetCreation] int  NOT NULL,
    [LieuProjetCreation_IdLieu] int  NOT NULL
);
GO

-- Creating table 'PersonneEnRechercheLieu'
CREATE TABLE [dbo].[PersonneEnRechercheLieu] (
    [RechercheColocation_IdRechercheColocation] int  NOT NULL,
    [Lieu_IdLieu] int  NOT NULL
);
GO

-- Creating table 'webpages_Userswebpages_Roles'
CREATE TABLE [dbo].[webpages_Userswebpages_Roles] (
    [webpages_Users_UsersId] int  NOT NULL,
    [webpages_Roles_IdRole] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAnnonceLocation] in table 'AnnonceLocationSet'
ALTER TABLE [dbo].[AnnonceLocationSet]
ADD CONSTRAINT [PK_AnnonceLocationSet]
    PRIMARY KEY CLUSTERED ([IdAnnonceLocation] ASC);
GO

-- Creating primary key on [IdChambreLocation] in table 'ChambreLocationSet'
ALTER TABLE [dbo].[ChambreLocationSet]
ADD CONSTRAINT [PK_ChambreLocationSet]
    PRIMARY KEY CLUSTERED ([IdChambreLocation] ASC);
GO

-- Creating primary key on [IdAnnonceProjetCreation] in table 'AnnonceProjetCreationSet'
ALTER TABLE [dbo].[AnnonceProjetCreationSet]
ADD CONSTRAINT [PK_AnnonceProjetCreationSet]
    PRIMARY KEY CLUSTERED ([IdAnnonceProjetCreation] ASC);
GO

-- Creating primary key on [IdLieu] in table 'LieuSet'
ALTER TABLE [dbo].[LieuSet]
ADD CONSTRAINT [PK_LieuSet]
    PRIMARY KEY CLUSTERED ([IdLieu] ASC);
GO

-- Creating primary key on [IdEvenement] in table 'EvenementSet'
ALTER TABLE [dbo].[EvenementSet]
ADD CONSTRAINT [PK_EvenementSet]
    PRIMARY KEY CLUSTERED ([IdEvenement] ASC);
GO

-- Creating primary key on [IdEvenementPresence] in table 'EvenementPresenceSet'
ALTER TABLE [dbo].[EvenementPresenceSet]
ADD CONSTRAINT [PK_EvenementPresenceSet]
    PRIMARY KEY CLUSTERED ([IdEvenementPresence] ASC);
GO

-- Creating primary key on [IdPublication] in table 'EvenementPublicationSet'
ALTER TABLE [dbo].[EvenementPublicationSet]
ADD CONSTRAINT [PK_EvenementPublicationSet]
    PRIMARY KEY CLUSTERED ([IdPublication] ASC);
GO

-- Creating primary key on [IdEcoColocExistante] in table 'EcoColocExistanteSet'
ALTER TABLE [dbo].[EcoColocExistanteSet]
ADD CONSTRAINT [PK_EcoColocExistanteSet]
    PRIMARY KEY CLUSTERED ([IdEcoColocExistante] ASC);
GO

-- Creating primary key on [IdEcoColocImage] in table 'ImageSet'
ALTER TABLE [dbo].[ImageSet]
ADD CONSTRAINT [PK_ImageSet]
    PRIMARY KEY CLUSTERED ([IdEcoColocImage] ASC);
GO

-- Creating primary key on [IdColocataire] in table 'ColocataireSet'
ALTER TABLE [dbo].[ColocataireSet]
ADD CONSTRAINT [PK_ColocataireSet]
    PRIMARY KEY CLUSTERED ([IdColocataire] ASC);
GO

-- Creating primary key on [IdConversationDev] in table 'ConversationDevSet'
ALTER TABLE [dbo].[ConversationDevSet]
ADD CONSTRAINT [PK_ConversationDevSet]
    PRIMARY KEY CLUSTERED ([IdConversationDev] ASC);
GO

-- Creating primary key on [IdRechercheColocation] in table 'RechercheColocationSet'
ALTER TABLE [dbo].[RechercheColocationSet]
ADD CONSTRAINT [PK_RechercheColocationSet]
    PRIMARY KEY CLUSTERED ([IdRechercheColocation] ASC);
GO

-- Creating primary key on [CreateDate] in table 'webpages_MembershipSet'
ALTER TABLE [dbo].[webpages_MembershipSet]
ADD CONSTRAINT [PK_webpages_MembershipSet]
    PRIMARY KEY CLUSTERED ([CreateDate] ASC);
GO

-- Creating primary key on [IdRole] in table 'webpages_RolesSet'
ALTER TABLE [dbo].[webpages_RolesSet]
ADD CONSTRAINT [PK_webpages_RolesSet]
    PRIMARY KEY CLUSTERED ([IdRole] ASC);
GO

-- Creating primary key on [UsersId] in table 'webpages_UsersSet'
ALTER TABLE [dbo].[webpages_UsersSet]
ADD CONSTRAINT [PK_webpages_UsersSet]
    PRIMARY KEY CLUSTERED ([UsersId] ASC);
GO

-- Creating primary key on [IdEvenementAssocie] in table 'EvenementAssocieSet'
ALTER TABLE [dbo].[EvenementAssocieSet]
ADD CONSTRAINT [PK_EvenementAssocieSet]
    PRIMARY KEY CLUSTERED ([IdEvenementAssocie] ASC);
GO

-- Creating primary key on [AnnonceProjetCreation_IdAnnonceProjetCreation], [LieuProjetCreation_IdLieu] in table 'ProjetCreationLieuProjetCreation'
ALTER TABLE [dbo].[ProjetCreationLieuProjetCreation]
ADD CONSTRAINT [PK_ProjetCreationLieuProjetCreation]
    PRIMARY KEY CLUSTERED ([AnnonceProjetCreation_IdAnnonceProjetCreation], [LieuProjetCreation_IdLieu] ASC);
GO

-- Creating primary key on [RechercheColocation_IdRechercheColocation], [Lieu_IdLieu] in table 'PersonneEnRechercheLieu'
ALTER TABLE [dbo].[PersonneEnRechercheLieu]
ADD CONSTRAINT [PK_PersonneEnRechercheLieu]
    PRIMARY KEY CLUSTERED ([RechercheColocation_IdRechercheColocation], [Lieu_IdLieu] ASC);
GO

-- Creating primary key on [webpages_Users_UsersId], [webpages_Roles_IdRole] in table 'webpages_Userswebpages_Roles'
ALTER TABLE [dbo].[webpages_Userswebpages_Roles]
ADD CONSTRAINT [PK_webpages_Userswebpages_Roles]
    PRIMARY KEY CLUSTERED ([webpages_Users_UsersId], [webpages_Roles_IdRole] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdAnnonceLocation] in table 'ChambreLocationSet'
ALTER TABLE [dbo].[ChambreLocationSet]
ADD CONSTRAINT [FK_LocationChambreLocation]
    FOREIGN KEY ([IdAnnonceLocation])
    REFERENCES [dbo].[AnnonceLocationSet]
        ([IdAnnonceLocation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LocationChambreLocation'
CREATE INDEX [IX_FK_LocationChambreLocation]
ON [dbo].[ChambreLocationSet]
    ([IdAnnonceLocation]);
GO

-- Creating foreign key on [AnnonceProjetCreation_IdAnnonceProjetCreation] in table 'ProjetCreationLieuProjetCreation'
ALTER TABLE [dbo].[ProjetCreationLieuProjetCreation]
ADD CONSTRAINT [FK_ProjetCreationLieuProjetCreation_ProjetCreation]
    FOREIGN KEY ([AnnonceProjetCreation_IdAnnonceProjetCreation])
    REFERENCES [dbo].[AnnonceProjetCreationSet]
        ([IdAnnonceProjetCreation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [LieuProjetCreation_IdLieu] in table 'ProjetCreationLieuProjetCreation'
ALTER TABLE [dbo].[ProjetCreationLieuProjetCreation]
ADD CONSTRAINT [FK_ProjetCreationLieuProjetCreation_LieuProjetCreation]
    FOREIGN KEY ([LieuProjetCreation_IdLieu])
    REFERENCES [dbo].[LieuSet]
        ([IdLieu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetCreationLieuProjetCreation_LieuProjetCreation'
CREATE INDEX [IX_FK_ProjetCreationLieuProjetCreation_LieuProjetCreation]
ON [dbo].[ProjetCreationLieuProjetCreation]
    ([LieuProjetCreation_IdLieu]);
GO

-- Creating foreign key on [IdEcoColocExistante] in table 'ColocataireSet'
ALTER TABLE [dbo].[ColocataireSet]
ADD CONSTRAINT [FK_EcoColocExistanteColocataire]
    FOREIGN KEY ([IdEcoColocExistante])
    REFERENCES [dbo].[EcoColocExistanteSet]
        ([IdEcoColocExistante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EcoColocExistanteColocataire'
CREATE INDEX [IX_FK_EcoColocExistanteColocataire]
ON [dbo].[ColocataireSet]
    ([IdEcoColocExistante]);
GO

-- Creating foreign key on [IdEcoColocExistante] in table 'ImageSet'
ALTER TABLE [dbo].[ImageSet]
ADD CONSTRAINT [FK_EcoColocExistanteEcoColocImage]
    FOREIGN KEY ([IdEcoColocExistante])
    REFERENCES [dbo].[EcoColocExistanteSet]
        ([IdEcoColocExistante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EcoColocExistanteEcoColocImage'
CREATE INDEX [IX_FK_EcoColocExistanteEcoColocImage]
ON [dbo].[ImageSet]
    ([IdEcoColocExistante]);
GO

-- Creating foreign key on [IdEvenement] in table 'EvenementPublicationSet'
ALTER TABLE [dbo].[EvenementPublicationSet]
ADD CONSTRAINT [FK_EvenementEvenementPublication]
    FOREIGN KEY ([IdEvenement])
    REFERENCES [dbo].[EvenementSet]
        ([IdEvenement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvenementEvenementPublication'
CREATE INDEX [IX_FK_EvenementEvenementPublication]
ON [dbo].[EvenementPublicationSet]
    ([IdEvenement]);
GO

-- Creating foreign key on [RechercheColocation_IdRechercheColocation] in table 'PersonneEnRechercheLieu'
ALTER TABLE [dbo].[PersonneEnRechercheLieu]
ADD CONSTRAINT [FK_PersonneEnRechercheLieu_PersonneEnRecherche]
    FOREIGN KEY ([RechercheColocation_IdRechercheColocation])
    REFERENCES [dbo].[RechercheColocationSet]
        ([IdRechercheColocation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Lieu_IdLieu] in table 'PersonneEnRechercheLieu'
ALTER TABLE [dbo].[PersonneEnRechercheLieu]
ADD CONSTRAINT [FK_PersonneEnRechercheLieu_Lieu]
    FOREIGN KEY ([Lieu_IdLieu])
    REFERENCES [dbo].[LieuSet]
        ([IdLieu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonneEnRechercheLieu_Lieu'
CREATE INDEX [IX_FK_PersonneEnRechercheLieu_Lieu]
ON [dbo].[PersonneEnRechercheLieu]
    ([Lieu_IdLieu]);
GO

-- Creating foreign key on [webpages_Users_UsersId] in table 'webpages_Userswebpages_Roles'
ALTER TABLE [dbo].[webpages_Userswebpages_Roles]
ADD CONSTRAINT [FK_webpages_Userswebpages_Roles_webpages_Users]
    FOREIGN KEY ([webpages_Users_UsersId])
    REFERENCES [dbo].[webpages_UsersSet]
        ([UsersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [webpages_Roles_IdRole] in table 'webpages_Userswebpages_Roles'
ALTER TABLE [dbo].[webpages_Userswebpages_Roles]
ADD CONSTRAINT [FK_webpages_Userswebpages_Roles_webpages_Roles]
    FOREIGN KEY ([webpages_Roles_IdRole])
    REFERENCES [dbo].[webpages_RolesSet]
        ([IdRole])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_Userswebpages_Roles_webpages_Roles'
CREATE INDEX [IX_FK_webpages_Userswebpages_Roles_webpages_Roles]
ON [dbo].[webpages_Userswebpages_Roles]
    ([webpages_Roles_IdRole]);
GO

-- Creating foreign key on [UsersId] in table 'webpages_MembershipSet'
ALTER TABLE [dbo].[webpages_MembershipSet]
ADD CONSTRAINT [FK_webpages_Userswebpages_Membership]
    FOREIGN KEY ([UsersId])
    REFERENCES [dbo].[webpages_UsersSet]
        ([UsersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_Userswebpages_Membership'
CREATE INDEX [IX_FK_webpages_Userswebpages_Membership]
ON [dbo].[webpages_MembershipSet]
    ([UsersId]);
GO

-- Creating foreign key on [IdUsers] in table 'AnnonceProjetCreationSet'
ALTER TABLE [dbo].[AnnonceProjetCreationSet]
ADD CONSTRAINT [FK_webpages_UsersProjetCreation]
    FOREIGN KEY ([IdUsers])
    REFERENCES [dbo].[webpages_UsersSet]
        ([UsersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_UsersProjetCreation'
CREATE INDEX [IX_FK_webpages_UsersProjetCreation]
ON [dbo].[AnnonceProjetCreationSet]
    ([IdUsers]);
GO

-- Creating foreign key on [UsersId] in table 'AnnonceLocationSet'
ALTER TABLE [dbo].[AnnonceLocationSet]
ADD CONSTRAINT [FK_webpages_UsersLocation]
    FOREIGN KEY ([UsersId])
    REFERENCES [dbo].[webpages_UsersSet]
        ([UsersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_UsersLocation'
CREATE INDEX [IX_FK_webpages_UsersLocation]
ON [dbo].[AnnonceLocationSet]
    ([UsersId]);
GO

-- Creating foreign key on [IdAnnonceProjetCreation] in table 'ImageSet'
ALTER TABLE [dbo].[ImageSet]
ADD CONSTRAINT [FK_AnnonceProjetCreationImage]
    FOREIGN KEY ([IdAnnonceProjetCreation])
    REFERENCES [dbo].[AnnonceProjetCreationSet]
        ([IdAnnonceProjetCreation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnnonceProjetCreationImage'
CREATE INDEX [IX_FK_AnnonceProjetCreationImage]
ON [dbo].[ImageSet]
    ([IdAnnonceProjetCreation]);
GO

-- Creating foreign key on [IdUser] in table 'EvenementPresenceSet'
ALTER TABLE [dbo].[EvenementPresenceSet]
ADD CONSTRAINT [FK_webpages_UsersEvenementPresence]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[webpages_UsersSet]
        ([UsersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_UsersEvenementPresence'
CREATE INDEX [IX_FK_webpages_UsersEvenementPresence]
ON [dbo].[EvenementPresenceSet]
    ([IdUser]);
GO

-- Creating foreign key on [IdEvenement] in table 'EvenementPresenceSet'
ALTER TABLE [dbo].[EvenementPresenceSet]
ADD CONSTRAINT [FK_EvenementEvenementPresence]
    FOREIGN KEY ([IdEvenement])
    REFERENCES [dbo].[EvenementSet]
        ([IdEvenement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvenementEvenementPresence'
CREATE INDEX [IX_FK_EvenementEvenementPresence]
ON [dbo].[EvenementPresenceSet]
    ([IdEvenement]);
GO

-- Creating foreign key on [IdEvenement] in table 'EvenementAssocieSet'
ALTER TABLE [dbo].[EvenementAssocieSet]
ADD CONSTRAINT [FK_EvenementEvenementAssocie]
    FOREIGN KEY ([IdEvenement])
    REFERENCES [dbo].[EvenementSet]
        ([IdEvenement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvenementEvenementAssocie'
CREATE INDEX [IX_FK_EvenementEvenementAssocie]
ON [dbo].[EvenementAssocieSet]
    ([IdEvenement]);
GO

-- Creating foreign key on [IdEvenementLink] in table 'EvenementAssocieSet'
ALTER TABLE [dbo].[EvenementAssocieSet]
ADD CONSTRAINT [FK_EvenementEvenementAssocie1]
    FOREIGN KEY ([IdEvenementLink])
    REFERENCES [dbo].[EvenementSet]
        ([IdEvenement])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvenementEvenementAssocie1'
CREATE INDEX [IX_FK_EvenementEvenementAssocie1]
ON [dbo].[EvenementAssocieSet]
    ([IdEvenementLink]);
GO

-- Creating foreign key on [IdConversationDev] in table 'ImageSet'
ALTER TABLE [dbo].[ImageSet]
ADD CONSTRAINT [FK_ConversationDevImage]
    FOREIGN KEY ([IdConversationDev])
    REFERENCES [dbo].[ConversationDevSet]
        ([IdConversationDev])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConversationDevImage'
CREATE INDEX [IX_FK_ConversationDevImage]
ON [dbo].[ImageSet]
    ([IdConversationDev]);
GO

-- Creating foreign key on [webpages_Users_UsersId] in table 'RechercheColocationSet'
ALTER TABLE [dbo].[RechercheColocationSet]
ADD CONSTRAINT [FK_RechercheColocationwebpages_Users]
    FOREIGN KEY ([webpages_Users_UsersId])
    REFERENCES [dbo].[webpages_UsersSet]
        ([UsersId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RechercheColocationwebpages_Users'
CREATE INDEX [IX_FK_RechercheColocationwebpages_Users]
ON [dbo].[RechercheColocationSet]
    ([webpages_Users_UsersId]);
GO

-- Creating foreign key on [webpages_UsersEcoColocExistante_webpages_Users_IdEcoColocExistante] in table 'webpages_UsersSet'
ALTER TABLE [dbo].[webpages_UsersSet]
ADD CONSTRAINT [FK_webpages_UsersEcoColocExistante]
    FOREIGN KEY ([webpages_UsersEcoColocExistante_webpages_Users_IdEcoColocExistante])
    REFERENCES [dbo].[EcoColocExistanteSet]
        ([IdEcoColocExistante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_UsersEcoColocExistante'
CREATE INDEX [IX_FK_webpages_UsersEcoColocExistante]
ON [dbo].[webpages_UsersSet]
    ([webpages_UsersEcoColocExistante_webpages_Users_IdEcoColocExistante]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------