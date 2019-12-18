
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/18/2019 13:15:50
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

IF OBJECT_ID(N'[dbo].[FK_RentalAd_RentalRoom]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentalRoom] DROP CONSTRAINT [FK_RentalAd_RentalRoom];
GO
IF OBJECT_ID(N'[dbo].[FK_Place_CreationProjectAd_CreationProjectAd]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Place_CreationProjectAd] DROP CONSTRAINT [FK_Place_CreationProjectAd_CreationProjectAd];
GO
IF OBJECT_ID(N'[dbo].[FK_Place_CreationProjectAd_Place]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Place_CreationProjectAd] DROP CONSTRAINT [FK_Place_CreationProjectAd_Place];
GO
IF OBJECT_ID(N'[dbo].[FK_Place_ResearchRoommate_ResearchRoommate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Place_ResearchRoommate] DROP CONSTRAINT [FK_Place_ResearchRoommate_ResearchRoommate];
GO
IF OBJECT_ID(N'[dbo].[FK_Place_ResearchRoommate_Place]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Place_ResearchRoommate] DROP CONSTRAINT [FK_Place_ResearchRoommate_Place];
GO
IF OBJECT_ID(N'[dbo].[FK_Event_PresenceEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PresenceEvent] DROP CONSTRAINT [FK_Event_PresenceEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_Event_AssociatedEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AssociatedEvent] DROP CONSTRAINT [FK_Event_AssociatedEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_Event_AssociatedEvent1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AssociatedEvent] DROP CONSTRAINT [FK_Event_AssociatedEvent1];
GO
IF OBJECT_ID(N'[dbo].[FK_DevConversation_PictureDevConversation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PictureDevConversation] DROP CONSTRAINT [FK_DevConversation_PictureDevConversation];
GO
IF OBJECT_ID(N'[dbo].[FK_EcoRoommateExisting_PictureEcoRoommateEx]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PictureEcoRoommateEx] DROP CONSTRAINT [FK_EcoRoommateExisting_PictureEcoRoommateEx];
GO
IF OBJECT_ID(N'[dbo].[FK_RentalAd_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentalAd] DROP CONSTRAINT [FK_RentalAd_User];
GO
IF OBJECT_ID(N'[dbo].[FK_PictureCreationProject_CreationProjectAd]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PictureCreationProject] DROP CONSTRAINT [FK_PictureCreationProject_CreationProjectAd];
GO
IF OBJECT_ID(N'[dbo].[FK_EcoRoommateExisting_Roommate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Roommate] DROP CONSTRAINT [FK_EcoRoommateExisting_Roommate];
GO
IF OBJECT_ID(N'[dbo].[FK_Person_ResearchRoommate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResearchRoommate] DROP CONSTRAINT [FK_Person_ResearchRoommate];
GO
IF OBJECT_ID(N'[dbo].[FK_Person_EcoRoommateExisting]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EcoRoommateExisting] DROP CONSTRAINT [FK_Person_EcoRoommateExisting];
GO
IF OBJECT_ID(N'[dbo].[FK_Person_PresenceEvent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PresenceEvent] DROP CONSTRAINT [FK_Person_PresenceEvent];
GO
IF OBJECT_ID(N'[dbo].[FK_Person_Event]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Event] DROP CONSTRAINT [FK_Person_Event];
GO
IF OBJECT_ID(N'[dbo].[FK_Person_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Person] DROP CONSTRAINT [FK_Person_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Agency_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Agency] DROP CONSTRAINT [FK_Agency_User];
GO
IF OBJECT_ID(N'[dbo].[FK_CreationProjectAd_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CreationProjectAd] DROP CONSTRAINT [FK_CreationProjectAd_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_webpages_Membership_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[webpages_Membership] DROP CONSTRAINT [FK_webpages_Membership_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RentalAd]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RentalAd];
GO
IF OBJECT_ID(N'[dbo].[RentalRoom]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RentalRoom];
GO
IF OBJECT_ID(N'[dbo].[CreationProjectAd]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CreationProjectAd];
GO
IF OBJECT_ID(N'[dbo].[Place]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Place];
GO
IF OBJECT_ID(N'[dbo].[Event]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Event];
GO
IF OBJECT_ID(N'[dbo].[PresenceEvent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PresenceEvent];
GO
IF OBJECT_ID(N'[dbo].[EcoRoommateExisting]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EcoRoommateExisting];
GO
IF OBJECT_ID(N'[dbo].[PictureDevConversation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PictureDevConversation];
GO
IF OBJECT_ID(N'[dbo].[Roommate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roommate];
GO
IF OBJECT_ID(N'[dbo].[DevConversation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DevConversation];
GO
IF OBJECT_ID(N'[dbo].[ResearchRoommate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResearchRoommate];
GO
IF OBJECT_ID(N'[dbo].[AssociatedEvent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AssociatedEvent];
GO
IF OBJECT_ID(N'[dbo].[PictureEcoRoommateEx]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PictureEcoRoommateEx];
GO
IF OBJECT_ID(N'[dbo].[PictureCreationProject]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PictureCreationProject];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[Agency]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agency];
GO
IF OBJECT_ID(N'[dbo].[Person]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Person];
GO
IF OBJECT_ID(N'[dbo].[webpages_Membership]', 'U') IS NOT NULL
    DROP TABLE [dbo].[webpages_Membership];
GO
IF OBJECT_ID(N'[dbo].[Place_CreationProjectAd]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Place_CreationProjectAd];
GO
IF OBJECT_ID(N'[dbo].[Place_ResearchRoommate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Place_ResearchRoommate];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RentalAd'
CREATE TABLE [dbo].[RentalAd] (
    [IdRentalAd] int IDENTITY(1,1) NOT NULL,
    [IdUser] int  NOT NULL,
    [Introduction] nvarchar(110)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Street] nvarchar(80)  NOT NULL,
    [City] nvarchar(50)  NOT NULL,
    [PostalCode] nvarchar(15)  NOT NULL,
    [Department] nvarchar(50)  NOT NULL,
    [DepartmentNumber] nvarchar(8)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [Country] nvarchar(50)  NOT NULL,
    [Latitude] decimal(9,6)  NOT NULL,
    [Longitude] decimal(9,6)  NOT NULL,
    [HousingType] tinyint  NOT NULL,
    [HousingImplantation] tinyint  NOT NULL,
    [HousingSurface] smallint  NOT NULL,
    [LandSurface] int  NOT NULL,
    [HousingPieceNumber] smallint  NOT NULL,
    [RoommateNumberStaying] smallint  NOT NULL,
    [RoommateNumberResearched] smallint  NOT NULL,
    [AccessHandicapped] bit  NOT NULL,
    [AccesPublicTransport] bit  NOT NULL,
    [AccesInfoSup] nvarchar(100)  NULL,
    [TolerationAlcoholConsommation] bit  NOT NULL,
    [TolerationSmoker] bit  NOT NULL,
    [TolerationPets] bit  NOT NULL,
    [TolerationInfoSup] nvarchar(100)  NULL,
    [DatePublish] datetime  NOT NULL,
    [ActivatedAnnouncement] bit  NOT NULL
);
GO

-- Creating table 'RentalRoom'
CREATE TABLE [dbo].[RentalRoom] (
    [IdRentalRoom] int IDENTITY(1,1) NOT NULL,
    [IdRentalAd] int  NOT NULL,
    [RentPrice] decimal(7,2)  NOT NULL,
    [Charges] decimal(7,2)  NOT NULL,
    [ChargesDetail] nvarchar(100)  NOT NULL,
    [Caution] decimal(7,2)  NULL,
    [Surface] smallint  NOT NULL,
    [Furnished] bit  NOT NULL,
    [AvalaibleDate] datetime  NOT NULL,
    [AvalaibleEndDate] datetime  NULL
);
GO

-- Creating table 'CreationProjectAd'
CREATE TABLE [dbo].[CreationProjectAd] (
    [IdCreationProject] int IDENTITY(1,1) NOT NULL,
    [IdPerson] int  NOT NULL,
    [Introduction] nvarchar(100)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [LandEngagement] tinyint  NULL,
    [LandMaxSurface] int  NULL,
    [LandMaxPrice] int  NULL,
    [HousingEngagement] tinyint  NOT NULL,
    [HousingType] tinyint  NOT NULL,
    [HousingImplantation] tinyint  NOT NULL,
    [HousingMaxSurface] smallint  NOT NULL,
    [HousingMaxPrice] int  NULL,
    [HousingMaxRent] smallint  NULL,
    [HousingMaxPriceBuilt] int  NULL,
    [TotalNumberPerson] smallint  NOT NULL,
    [NbPersonToBuyLand] smallint  NULL,
    [NbPersonToBuyHousing] smallint  NULL,
    [NbPersonToRentHousing] smallint  NULL,
    [AccesPublicTransport] tinyint  NOT NULL,
    [AccesInfoSup] nvarchar(100)  NULL,
    [TolerationAlcoholConsommation] bit  NOT NULL,
    [TolerationSmoker] bit  NOT NULL,
    [TolerationPets] bit  NOT NULL,
    [TolerationInfoSup] nvarchar(100)  NULL,
    [ActivatedAnnouncement] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Place'
CREATE TABLE [dbo].[Place] (
    [IdPlace] int IDENTITY(1,1) NOT NULL,
    [City] nvarchar(50)  NULL,
    [PostalCode] nvarchar(15)  NULL,
    [Department] nvarchar(50)  NULL,
    [DepartmentNumber] nvarchar(8)  NULL,
    [Region] nvarchar(50)  NULL,
    [County] nvarchar(50)  NOT NULL,
    [ScopeResearch] tinyint  NOT NULL,
    [CreationProjectAd_IdCreationProject] int  NOT NULL,
    [ResearchRoommate_IdResearchRoommate] int  NOT NULL
);
GO

-- Creating table 'Event'
CREATE TABLE [dbo].[Event] (
    [IdEvent] int IDENTITY(1,1) NOT NULL,
    [IdPerson] int  NOT NULL,
    [DateStart] datetime  NOT NULL,
    [DateEnd] datetime  NOT NULL,
    [StreetNumber] nvarchar(10)  NOT NULL,
    [StreetName] nvarchar(80)  NOT NULL,
    [City] nvarchar(60)  NOT NULL,
    [PostalCode] nvarchar(15)  NOT NULL,
    [Department] nvarchar(50)  NOT NULL,
    [DepartmentNumber] nvarchar(8)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [Country] nvarchar(50)  NOT NULL,
    [Link] nvarchar(500)  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [PictureName] nvarchar(50)  NULL,
    [DatePublish] datetime  NOT NULL
);
GO

-- Creating table 'PresenceEvent'
CREATE TABLE [dbo].[PresenceEvent] (
    [IdPerson] int  NOT NULL,
    [IdEvent] int  NOT NULL,
    [Status] tinyint  NOT NULL
);
GO

-- Creating table 'EcoRoommateExisting'
CREATE TABLE [dbo].[EcoRoommateExisting] (
    [IdEcoRoommateExisting] int IDENTITY(1,1) NOT NULL,
    [IdPerson] int  NOT NULL,
    [EcoRoommateName] nvarchar(50)  NOT NULL,
    [RommateNumber] smallint  NOT NULL,
    [Country] nvarchar(50)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [Department] nvarchar(50)  NOT NULL,
    [DepartmentNumber] nvarchar(8)  NOT NULL,
    [City] nvarchar(50)  NOT NULL,
    [PostalCode] nvarchar(15)  NOT NULL,
    [Email] nvarchar(60)  NULL,
    [Description] nvarchar(max)  NOT NULL,
    [EcoImplication] tinyint  NOT NULL,
    [TableEco] nvarchar(max)  NOT NULL,
    [TableHousing] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PictureDevConversation'
CREATE TABLE [dbo].[PictureDevConversation] (
    [IdPictureDevConversation] int IDENTITY(1,1) NOT NULL,
    [IdDevConversation] int  NOT NULL,
    [PictureName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Roommate'
CREATE TABLE [dbo].[Roommate] (
    [IdRoommate] int IDENTITY(1,1) NOT NULL,
    [IdEcoRoommateExisting] int  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Email] nvarchar(60)  NOT NULL,
    [DateBirth] nvarchar(10)  NOT NULL,
    [Civility] tinyint  NOT NULL
);
GO

-- Creating table 'DevConversation'
CREATE TABLE [dbo].[DevConversation] (
    [IdDevConversation] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Message] nvarchar(max)  NOT NULL,
    [DateLastSend] datetime  NOT NULL,
    [Viewed] tinyint  NOT NULL
);
GO

-- Creating table 'ResearchRoommate'
CREATE TABLE [dbo].[ResearchRoommate] (
    [IdResearchRoommate] int IDENTITY(1,1) NOT NULL,
    [IdPerson] int  NOT NULL,
    [MaxBudget] smallint  NOT NULL,
    [EmailAlert] tinyint  NOT NULL,
    [SearchCriteria] nvarchar(max)  NOT NULL,
    [EcoPractice] nvarchar(max)  NOT NULL,
    [PictureName] nvarchar(50)  NOT NULL,
    [ActivatedAnnouncement] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AssociatedEvent'
CREATE TABLE [dbo].[AssociatedEvent] (
    [IdEvent] int  NOT NULL,
    [IdAssociatedEvent] int  NOT NULL
);
GO

-- Creating table 'PictureEcoRoommateEx'
CREATE TABLE [dbo].[PictureEcoRoommateEx] (
    [IdPictureEcoRoommateEx] int IDENTITY(1,1) NOT NULL,
    [IdEcoRoommateExisting] int  NOT NULL,
    [PictureName] nvarchar(50)  NOT NULL,
    [OrderNumber] tinyint  NOT NULL
);
GO

-- Creating table 'PictureCreationProject'
CREATE TABLE [dbo].[PictureCreationProject] (
    [IdPictureCreationProject] int IDENTITY(1,1) NOT NULL,
    [IdProjetCreation] int  NOT NULL,
    [PictureName] nvarchar(50)  NOT NULL,
    [OrderNumber] tinyint  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [IdUser] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(60)  NOT NULL,
    [TypeUser] tinyint  NOT NULL,
    [Activated] bit  NOT NULL
);
GO

-- Creating table 'Agency'
CREATE TABLE [dbo].[Agency] (
    [IdAgency] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Email] nvarchar(60)  NOT NULL,
    [Phone] nvarchar(12)  NOT NULL,
    [StreetNumber] nvarchar(10)  NOT NULL,
    [Street] nvarchar(80)  NOT NULL,
    [City] nvarchar(50)  NOT NULL,
    [PostalCode] nvarchar(15)  NOT NULL,
    [Department] nvarchar(50)  NOT NULL,
    [DepartmentNumber] nvarchar(8)  NOT NULL,
    [Region] nvarchar(50)  NOT NULL,
    [County] nvarchar(50)  NOT NULL,
    [SiretNumber] nvarchar(14)  NOT NULL,
    [AgencyFees] decimal(7,2)  NOT NULL,
    [User_IdUser] int  NOT NULL
);
GO

-- Creating table 'Person'
CREATE TABLE [dbo].[Person] (
    [IdPerson] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(60)  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Civility] tinyint  NOT NULL,
    [Country] nvarchar(50)  NOT NULL,
    [DateBirth] nvarchar(10)  NOT NULL,
    [Activity] tinyint  NULL,
    [PhoneCode] nvarchar(15)  NOT NULL,
    [PhoneNumber] nvarchar(12)  NOT NULL,
    [ContactType] tinyint  NULL,
    [PersonnalityDescription] nvarchar(500)  NULL,
    [DateInscription] datetime  NOT NULL,
    [DateLastActivity] datetime  NOT NULL,
    [Person_User_Person_IdUser] int  NOT NULL
);
GO

-- Creating table 'webpages_Membership'
CREATE TABLE [dbo].[webpages_Membership] (
    [IdMembership] int  NOT NULL,
    [CreateDate] datetime  NULL,
    [ConfirmationToken] nvarchar(128)  NULL,
    [IsConfirmed] bit  NULL,
    [LastPasswordFailureDate] datetime  NULL,
    [PasswordFailuresSinceLastSuccess] int  NOT NULL,
    [Password] nvarchar(128)  NOT NULL,
    [PasswordChangedDate] datetime  NULL,
    [PasswordSalt] nvarchar(128)  NOT NULL,
    [PasswordVerificationToken] nvarchar(128)  NULL,
    [PasswordVerificationTokenExpirationDate] datetime  NULL,
    [User_IdUser] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdRentalAd] in table 'RentalAd'
ALTER TABLE [dbo].[RentalAd]
ADD CONSTRAINT [PK_RentalAd]
    PRIMARY KEY CLUSTERED ([IdRentalAd] ASC);
GO

-- Creating primary key on [IdRentalRoom] in table 'RentalRoom'
ALTER TABLE [dbo].[RentalRoom]
ADD CONSTRAINT [PK_RentalRoom]
    PRIMARY KEY CLUSTERED ([IdRentalRoom] ASC);
GO

-- Creating primary key on [IdCreationProject] in table 'CreationProjectAd'
ALTER TABLE [dbo].[CreationProjectAd]
ADD CONSTRAINT [PK_CreationProjectAd]
    PRIMARY KEY CLUSTERED ([IdCreationProject] ASC);
GO

-- Creating primary key on [IdPlace] in table 'Place'
ALTER TABLE [dbo].[Place]
ADD CONSTRAINT [PK_Place]
    PRIMARY KEY CLUSTERED ([IdPlace] ASC);
GO

-- Creating primary key on [IdEvent] in table 'Event'
ALTER TABLE [dbo].[Event]
ADD CONSTRAINT [PK_Event]
    PRIMARY KEY CLUSTERED ([IdEvent] ASC);
GO

-- Creating primary key on [IdEvent], [IdPerson] in table 'PresenceEvent'
ALTER TABLE [dbo].[PresenceEvent]
ADD CONSTRAINT [PK_PresenceEvent]
    PRIMARY KEY CLUSTERED ([IdEvent], [IdPerson] ASC);
GO

-- Creating primary key on [IdEcoRoommateExisting] in table 'EcoRoommateExisting'
ALTER TABLE [dbo].[EcoRoommateExisting]
ADD CONSTRAINT [PK_EcoRoommateExisting]
    PRIMARY KEY CLUSTERED ([IdEcoRoommateExisting] ASC);
GO

-- Creating primary key on [IdPictureDevConversation] in table 'PictureDevConversation'
ALTER TABLE [dbo].[PictureDevConversation]
ADD CONSTRAINT [PK_PictureDevConversation]
    PRIMARY KEY CLUSTERED ([IdPictureDevConversation] ASC);
GO

-- Creating primary key on [IdRoommate] in table 'Roommate'
ALTER TABLE [dbo].[Roommate]
ADD CONSTRAINT [PK_Roommate]
    PRIMARY KEY CLUSTERED ([IdRoommate] ASC);
GO

-- Creating primary key on [IdDevConversation] in table 'DevConversation'
ALTER TABLE [dbo].[DevConversation]
ADD CONSTRAINT [PK_DevConversation]
    PRIMARY KEY CLUSTERED ([IdDevConversation] ASC);
GO

-- Creating primary key on [IdResearchRoommate] in table 'ResearchRoommate'
ALTER TABLE [dbo].[ResearchRoommate]
ADD CONSTRAINT [PK_ResearchRoommate]
    PRIMARY KEY CLUSTERED ([IdResearchRoommate] ASC);
GO

-- Creating primary key on [IdEvent], [IdAssociatedEvent] in table 'AssociatedEvent'
ALTER TABLE [dbo].[AssociatedEvent]
ADD CONSTRAINT [PK_AssociatedEvent]
    PRIMARY KEY CLUSTERED ([IdEvent], [IdAssociatedEvent] ASC);
GO

-- Creating primary key on [IdPictureEcoRoommateEx] in table 'PictureEcoRoommateEx'
ALTER TABLE [dbo].[PictureEcoRoommateEx]
ADD CONSTRAINT [PK_PictureEcoRoommateEx]
    PRIMARY KEY CLUSTERED ([IdPictureEcoRoommateEx] ASC);
GO

-- Creating primary key on [IdPictureCreationProject] in table 'PictureCreationProject'
ALTER TABLE [dbo].[PictureCreationProject]
ADD CONSTRAINT [PK_PictureCreationProject]
    PRIMARY KEY CLUSTERED ([IdPictureCreationProject] ASC);
GO

-- Creating primary key on [IdUser] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([IdUser] ASC);
GO

-- Creating primary key on [IdAgency] in table 'Agency'
ALTER TABLE [dbo].[Agency]
ADD CONSTRAINT [PK_Agency]
    PRIMARY KEY CLUSTERED ([IdAgency] ASC);
GO

-- Creating primary key on [IdPerson] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [PK_Person]
    PRIMARY KEY CLUSTERED ([IdPerson] ASC);
GO

-- Creating primary key on [IdMembership] in table 'webpages_Membership'
ALTER TABLE [dbo].[webpages_Membership]
ADD CONSTRAINT [PK_webpages_Membership]
    PRIMARY KEY CLUSTERED ([IdMembership] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdRentalAd] in table 'RentalRoom'
ALTER TABLE [dbo].[RentalRoom]
ADD CONSTRAINT [FK_RentalAd_RentalRoom]
    FOREIGN KEY ([IdRentalAd])
    REFERENCES [dbo].[RentalAd]
        ([IdRentalAd])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RentalAd_RentalRoom'
CREATE INDEX [IX_FK_RentalAd_RentalRoom]
ON [dbo].[RentalRoom]
    ([IdRentalAd]);
GO

-- Creating foreign key on [CreationProjectAd_IdCreationProject] in table 'Place'
ALTER TABLE [dbo].[Place]
ADD CONSTRAINT [FK_Place_CreationProjectAd]
    FOREIGN KEY ([CreationProjectAd_IdCreationProject])
    REFERENCES [dbo].[CreationProjectAd]
        ([IdCreationProject])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Place_CreationProjectAd'
CREATE INDEX [IX_FK_Place_CreationProjectAd]
ON [dbo].[Place]
    ([CreationProjectAd_IdCreationProject]);
GO

-- Creating foreign key on [ResearchRoommate_IdResearchRoommate] in table 'Place'
ALTER TABLE [dbo].[Place]
ADD CONSTRAINT [FK_Place_ResearchRoommate]
    FOREIGN KEY ([ResearchRoommate_IdResearchRoommate])
    REFERENCES [dbo].[ResearchRoommate]
        ([IdResearchRoommate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Place_ResearchRoommate'
CREATE INDEX [IX_FK_Place_ResearchRoommate]
ON [dbo].[Place]
    ([ResearchRoommate_IdResearchRoommate]);
GO

-- Creating foreign key on [IdEvent] in table 'PresenceEvent'
ALTER TABLE [dbo].[PresenceEvent]
ADD CONSTRAINT [FK_Event_PresenceEvent]
    FOREIGN KEY ([IdEvent])
    REFERENCES [dbo].[Event]
        ([IdEvent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEvent] in table 'AssociatedEvent'
ALTER TABLE [dbo].[AssociatedEvent]
ADD CONSTRAINT [FK_Event_AssociatedEvent]
    FOREIGN KEY ([IdEvent])
    REFERENCES [dbo].[Event]
        ([IdEvent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdAssociatedEvent] in table 'AssociatedEvent'
ALTER TABLE [dbo].[AssociatedEvent]
ADD CONSTRAINT [FK_Event_AssociatedEvent1]
    FOREIGN KEY ([IdAssociatedEvent])
    REFERENCES [dbo].[Event]
        ([IdEvent])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Event_AssociatedEvent1'
CREATE INDEX [IX_FK_Event_AssociatedEvent1]
ON [dbo].[AssociatedEvent]
    ([IdAssociatedEvent]);
GO

-- Creating foreign key on [IdDevConversation] in table 'PictureDevConversation'
ALTER TABLE [dbo].[PictureDevConversation]
ADD CONSTRAINT [FK_DevConversation_PictureDevConversation]
    FOREIGN KEY ([IdDevConversation])
    REFERENCES [dbo].[DevConversation]
        ([IdDevConversation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DevConversation_PictureDevConversation'
CREATE INDEX [IX_FK_DevConversation_PictureDevConversation]
ON [dbo].[PictureDevConversation]
    ([IdDevConversation]);
GO

-- Creating foreign key on [IdEcoRoommateExisting] in table 'PictureEcoRoommateEx'
ALTER TABLE [dbo].[PictureEcoRoommateEx]
ADD CONSTRAINT [FK_EcoRoommateExisting_PictureEcoRoommateEx]
    FOREIGN KEY ([IdEcoRoommateExisting])
    REFERENCES [dbo].[EcoRoommateExisting]
        ([IdEcoRoommateExisting])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EcoRoommateExisting_PictureEcoRoommateEx'
CREATE INDEX [IX_FK_EcoRoommateExisting_PictureEcoRoommateEx]
ON [dbo].[PictureEcoRoommateEx]
    ([IdEcoRoommateExisting]);
GO

-- Creating foreign key on [IdUser] in table 'RentalAd'
ALTER TABLE [dbo].[RentalAd]
ADD CONSTRAINT [FK_RentalAd_User]
    FOREIGN KEY ([IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RentalAd_User'
CREATE INDEX [IX_FK_RentalAd_User]
ON [dbo].[RentalAd]
    ([IdUser]);
GO

-- Creating foreign key on [IdProjetCreation] in table 'PictureCreationProject'
ALTER TABLE [dbo].[PictureCreationProject]
ADD CONSTRAINT [FK_PictureCreationProject_CreationProjectAd]
    FOREIGN KEY ([IdProjetCreation])
    REFERENCES [dbo].[CreationProjectAd]
        ([IdCreationProject])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PictureCreationProject_CreationProjectAd'
CREATE INDEX [IX_FK_PictureCreationProject_CreationProjectAd]
ON [dbo].[PictureCreationProject]
    ([IdProjetCreation]);
GO

-- Creating foreign key on [IdEcoRoommateExisting] in table 'Roommate'
ALTER TABLE [dbo].[Roommate]
ADD CONSTRAINT [FK_EcoRoommateExisting_Roommate]
    FOREIGN KEY ([IdEcoRoommateExisting])
    REFERENCES [dbo].[EcoRoommateExisting]
        ([IdEcoRoommateExisting])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EcoRoommateExisting_Roommate'
CREATE INDEX [IX_FK_EcoRoommateExisting_Roommate]
ON [dbo].[Roommate]
    ([IdEcoRoommateExisting]);
GO

-- Creating foreign key on [IdPerson] in table 'ResearchRoommate'
ALTER TABLE [dbo].[ResearchRoommate]
ADD CONSTRAINT [FK_Person_ResearchRoommate]
    FOREIGN KEY ([IdPerson])
    REFERENCES [dbo].[Person]
        ([IdPerson])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Person_ResearchRoommate'
CREATE INDEX [IX_FK_Person_ResearchRoommate]
ON [dbo].[ResearchRoommate]
    ([IdPerson]);
GO

-- Creating foreign key on [IdPerson] in table 'EcoRoommateExisting'
ALTER TABLE [dbo].[EcoRoommateExisting]
ADD CONSTRAINT [FK_Person_EcoRoommateExisting]
    FOREIGN KEY ([IdPerson])
    REFERENCES [dbo].[Person]
        ([IdPerson])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Person_EcoRoommateExisting'
CREATE INDEX [IX_FK_Person_EcoRoommateExisting]
ON [dbo].[EcoRoommateExisting]
    ([IdPerson]);
GO

-- Creating foreign key on [IdPerson] in table 'PresenceEvent'
ALTER TABLE [dbo].[PresenceEvent]
ADD CONSTRAINT [FK_Person_PresenceEvent]
    FOREIGN KEY ([IdPerson])
    REFERENCES [dbo].[Person]
        ([IdPerson])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Person_PresenceEvent'
CREATE INDEX [IX_FK_Person_PresenceEvent]
ON [dbo].[PresenceEvent]
    ([IdPerson]);
GO

-- Creating foreign key on [IdPerson] in table 'Event'
ALTER TABLE [dbo].[Event]
ADD CONSTRAINT [FK_Person_Event]
    FOREIGN KEY ([IdPerson])
    REFERENCES [dbo].[Person]
        ([IdPerson])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Person_Event'
CREATE INDEX [IX_FK_Person_Event]
ON [dbo].[Event]
    ([IdPerson]);
GO

-- Creating foreign key on [Person_User_Person_IdUser] in table 'Person'
ALTER TABLE [dbo].[Person]
ADD CONSTRAINT [FK_Person_User]
    FOREIGN KEY ([Person_User_Person_IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Person_User'
CREATE INDEX [IX_FK_Person_User]
ON [dbo].[Person]
    ([Person_User_Person_IdUser]);
GO

-- Creating foreign key on [User_IdUser] in table 'Agency'
ALTER TABLE [dbo].[Agency]
ADD CONSTRAINT [FK_Agency_User]
    FOREIGN KEY ([User_IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Agency_User'
CREATE INDEX [IX_FK_Agency_User]
ON [dbo].[Agency]
    ([User_IdUser]);
GO

-- Creating foreign key on [IdPerson] in table 'CreationProjectAd'
ALTER TABLE [dbo].[CreationProjectAd]
ADD CONSTRAINT [FK_CreationProjectAd_Person]
    FOREIGN KEY ([IdPerson])
    REFERENCES [dbo].[Person]
        ([IdPerson])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CreationProjectAd_Person'
CREATE INDEX [IX_FK_CreationProjectAd_Person]
ON [dbo].[CreationProjectAd]
    ([IdPerson]);
GO

-- Creating foreign key on [User_IdUser] in table 'webpages_Membership'
ALTER TABLE [dbo].[webpages_Membership]
ADD CONSTRAINT [FK_webpages_Membership_User]
    FOREIGN KEY ([User_IdUser])
    REFERENCES [dbo].[User]
        ([IdUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_webpages_Membership_User'
CREATE INDEX [IX_FK_webpages_Membership_User]
ON [dbo].[webpages_Membership]
    ([User_IdUser]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------