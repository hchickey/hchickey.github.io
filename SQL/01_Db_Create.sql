USE [master]

IF db_id('MyProfile') IS NULl
  CREATE DATABASE [MyProfile]
GO

USE [MyProfile]
GO


DROP TABLE IF EXISTS [Basic];
DROP TABLE IF EXISTS [Profile];
DROP TABLE IF EXISTS [Interest];
DROP TABLE IF EXISTS [Skill];
DROP TABLE IF EXISTS [Education];
DROP TABLE IF EXISTS [Work];
DROP TABLE IF EXISTS [Volunteer];
GO


CREATE TABLE [Basic] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Name] nvarchar(20) NOT NULL,
  [ImageUrl] nvarchar(255),
  [Email] nvarchar(255) NOT NULL,
  [Phone] nvarchar(255) NOT NULL,
  [Summary] nvarchar(555) NOT NULL,
)

CREATE TABLE [UserProfile] (
  [Id] integer PRIMARY KEY IDENTITY,
  [FirebaseUserId] NVARCHAR(28) NOT NULL,
  [DisplayName] nvarchar(50) NOT NULL,
  [FirstName] nvarchar(50) NOT NULL,
  [LastName] nvarchar(50) NOT NULL,
  [Email] nvarchar(555) NOT NULL,

  CONSTRAINT UQ_FirebaseUserId UNIQUE(FirebaseUserId)
)

CREATE TABLE [Profile] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Network] nvarchar(50) NOT NULL,
  [UserName] nvarchar(50) NOT NULL,
  [Url] nvarchar(255) NOT NULL,

)

CREATE TABLE [Interest] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Hobby] nvarchar(555) NOT NULL
)

CREATE TABLE [Skill] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Title] nvarchar(255) NOT NULL,
  [Level] nvarchar(50) NOT NULL,
  [Keyword] nvarchar(255) NOT NULL,
)

CREATE TABLE [Education] (
  [Id] integer PRIMARY KEY IDENTITY,
  [School] nvarchar(255) NOT NULL,
  [Area] nvarchar(50) NOT NULL,
  [StudyType] nvarchar(255),
  [StartDate] datetime NOT NULL,
  [EndDate] datetime NOT NULL,
)

CREATE TABLE [Work] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Company] nvarchar(255) NOT NULL,
  [Position] nvarchar(555) NOT NULL,
  [Website] nvarchar(555) NOT NULL,
  [StartDate] datetime NOT NULL,
  [EndDate] datetime NOT NULL,
  [Summary] nvarchar(555) NOT NULL,

)

CREATE TABLE [Volunteer] (
  [Id] integer PRIMARY KEY IDENTITY,
  [Organization] nvarchar(255) NOT NULL,
  [Sumary] nvarchar(555) NOT NULL,
  
)
GO