USE [master]
GO
/****** Object:  Database [EventManager]    Script Date: 28.05.2019 01:03:28 ******/
CREATE DATABASE [EventManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EventManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\EventManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EventManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\EventManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EventManager] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EventManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EventManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EventManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EventManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EventManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EventManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [EventManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EventManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EventManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EventManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EventManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EventManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EventManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EventManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EventManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EventManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EventManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EventManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EventManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EventManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EventManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EventManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EventManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EventManager] SET RECOVERY FULL 
GO
ALTER DATABASE [EventManager] SET  MULTI_USER 
GO
ALTER DATABASE [EventManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EventManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EventManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EventManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EventManager] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EventManager', N'ON'
GO
ALTER DATABASE [EventManager] SET QUERY_STORE = OFF
GO
USE [EventManager]
GO
/****** Object:  User [yasin]    Script Date: 28.05.2019 01:03:28 ******/
CREATE USER [yasin] FOR LOGIN [yasin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 28.05.2019 01:03:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 28.05.2019 01:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[EventName] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ApplicationDate] [datetime] NOT NULL,
	[NumberOfPersons] [int] NOT NULL,
	[EventImage] [nvarchar](300) NOT NULL,
	[Description] [nvarchar](400) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 28.05.2019 01:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[MessageFrom] [int] NOT NULL,
	[MessageTo] [int] NOT NULL,
	[MessageDate] [datetime] NOT NULL,
	[MessageBody] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 28.05.2019 01:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonID], [FirstName], [DateOfBirth], [UserName], [Password]) VALUES (1, N'Yasin', CAST(N'2019-05-23' AS Date), N'SippinSyrup', N'12345')
INSERT [dbo].[Person] ([PersonID], [FirstName], [DateOfBirth], [UserName], [Password]) VALUES (2, N'İsmail', CAST(N'1990-05-17' AS Date), N'Ismailisik', N'123')
INSERT [dbo].[Person] ([PersonID], [FirstName], [DateOfBirth], [UserName], [Password]) VALUES (3, N'Mahir', CAST(N'2019-05-15' AS Date), N'Mahirgulecoglu', N'123')
INSERT [dbo].[Person] ([PersonID], [FirstName], [DateOfBirth], [UserName], [Password]) VALUES (4, N'Göktuğ', CAST(N'1993-05-13' AS Date), N'GoktugErcaliskan', N'123')
INSERT [dbo].[Person] ([PersonID], [FirstName], [DateOfBirth], [UserName], [Password]) VALUES (5, N'Furkan', CAST(N'2019-05-09' AS Date), N'FurkanGulec', N'123')
INSERT [dbo].[Person] ([PersonID], [FirstName], [DateOfBirth], [UserName], [Password]) VALUES (6, N'dhggh', CAST(N'2019-05-24' AS Date), N'dfghdfhg', N'12345')
SET IDENTITY_INSERT [dbo].[Person] OFF
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Category]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Person]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Person] FOREIGN KEY([MessageFrom])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Person]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Person1] FOREIGN KEY([MessageTo])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Person1]
GO
USE [master]
GO
ALTER DATABASE [EventManager] SET  READ_WRITE 
GO
