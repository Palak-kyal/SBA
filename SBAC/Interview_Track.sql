USE [master]
GO
/****** Object:  Database [Interview_Track]    Script Date: 13-10-2021 17:45:24 ******/
CREATE DATABASE [Interview_Track]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Interview_Track', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Interview_Track.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Interview_Track_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Interview_Track_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Interview_Track] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Interview_Track].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Interview_Track] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Interview_Track] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Interview_Track] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Interview_Track] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Interview_Track] SET ARITHABORT OFF 
GO
ALTER DATABASE [Interview_Track] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Interview_Track] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Interview_Track] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Interview_Track] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Interview_Track] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Interview_Track] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Interview_Track] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Interview_Track] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Interview_Track] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Interview_Track] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Interview_Track] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Interview_Track] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Interview_Track] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Interview_Track] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Interview_Track] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Interview_Track] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Interview_Track] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Interview_Track] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Interview_Track] SET  MULTI_USER 
GO
ALTER DATABASE [Interview_Track] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Interview_Track] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Interview_Track] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Interview_Track] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Interview_Track] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Interview_Track] SET QUERY_STORE = OFF
GO
USE [Interview_Track]
GO
/****** Object:  Table [dbo].[Admin_Login]    Script Date: 13-10-2021 17:45:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin_Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin_Rgister]    Script Date: 13-10-2021 17:45:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin_Rgister](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [nvarchar](50) NULL,
	[Lname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Mobile] [numeric](10, 0) NULL,
	[ContactAddress] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interviewers]    Script Date: 13-10-2021 17:45:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interviewers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Skill] [nvarchar](50) NULL,
	[Experience] [int] NULL,
	[Interview_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Register]    Script Date: 13-10-2021 17:45:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Register](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [nvarchar](50) NULL,
	[Lname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Mobile] [numeric](10, 0) NULL,
	[Report] [nvarchar](50) NULL,
	[UserStatus] [nvarchar](50) NULL,
	[UserType] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin_Rgister] ON 

INSERT [dbo].[Admin_Rgister] ([id], [Fname], [Lname], [Email], [Mobile], [ContactAddress], [Password]) VALUES (1, N'amdin', N'jdfhfkjh', N'abc@gmail.com', CAST(7859689569 AS Numeric(10, 0)), N'ksdbkf', N'admin')
SET IDENTITY_INSERT [dbo].[Admin_Rgister] OFF
GO
SET IDENTITY_INSERT [dbo].[Interviewers] ON 

INSERT [dbo].[Interviewers] ([id], [Name], [Skill], [Experience], [Interview_date]) VALUES (1, N'Manoj S.', N'Java', 4, CAST(N'2021-05-12' AS Date))
SET IDENTITY_INSERT [dbo].[Interviewers] OFF
GO
SET IDENTITY_INSERT [dbo].[User_Register] ON 

INSERT [dbo].[User_Register] ([id], [Fname], [Lname], [Email], [Mobile], [Report], [UserStatus], [UserType], [Password]) VALUES (1, N'abc', N'wer', N'adhg@gmail.com', CAST(7845896598 AS Numeric(10, 0)), N'sdf', N'Active', N'1. Trainee', NULL)
SET IDENTITY_INSERT [dbo].[User_Register] OFF
GO
USE [master]
GO
ALTER DATABASE [Interview_Track] SET  READ_WRITE 
GO
