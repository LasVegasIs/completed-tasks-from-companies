USE [StaffSelection]
GO
CREATE TABLE [dbo].[tbPersonalData](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[FIRSTNAME] [nvarchar](70) NOT NULL,
	[SECONDNAME] [nvarchar] (70) NOT NULL,
	[LASTNAME] [nvarchar] (70) NULL,
	[DATEBIRTH] [date] NOT NULL,
	[PASSNUMBER] [nvarchar] (9) NOT NULL	
	)
GO
CREATE TABLE [dbo].[tbEducTypes](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[NAME] [nvarchar](20) NULL	
	)
GO
CREATE TABLE [dbo].[tbEduacation](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[NAME] [nvarchar](70) NULL,
	[ADDRESS] [nvarchar] (150) NULL,
	[ID_TYPE] int NOT NULL
 CONSTRAINT fk_educ_type
    FOREIGN KEY (ID_TYPE)
    REFERENCES [dbo].[tbEducTypes] (ID)
	)
GO
CREATE TABLE [dbo].[tbPersonEduc](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ID_PERSON] int NOT NULL,
	[ID_EDUC] int NOT NULL	
 CONSTRAINT fk_personEduc
    FOREIGN KEY (ID_PERSON)
    REFERENCES [dbo].[tbPersonalData] (ID),
 CONSTRAINT fk_educPerson
    FOREIGN KEY (ID_EDUC)
    REFERENCES [dbo].[tbEduacation] (ID)
	)
GO
CREATE TABLE [dbo].[tbSkills](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[PID] [int] NOT NULL DEFAULT 0,	
	[NAME] [nvarchar](200) NOT NULL
	)
GO
CREATE TABLE [dbo].[tbExperience](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ID_PERSON] int NULL,
	[ID_SKILL] int NOT NULL,
	[IDP_SKILL]  int NOT NULL,
	[YEARS] numeric(10)
 CONSTRAINT fk_personExp
    FOREIGN KEY (ID_PERSON)
    REFERENCES [dbo].[tbPersonalData] (ID),
 CONSTRAINT fk_skillExp
    FOREIGN KEY (ID_SKILL)
    REFERENCES [dbo].[tbSkills] (ID)              
	)



