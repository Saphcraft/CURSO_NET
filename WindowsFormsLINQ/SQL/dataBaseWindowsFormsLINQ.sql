USE [master]
GO
/****** Object:  Database [WINDOWSFORMLINQ]    Script Date: 02/08/2021 17:05:41 ******/
CREATE DATABASE [WINDOWSFORMLINQ] ON  PRIMARY 
( NAME = N'WINDOWSFORMLINQ', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESSSAPH\MSSQL\DATA\WINDOWSFORMLINQ.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WINDOWSFORMLINQ_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESSSAPH\MSSQL\DATA\WINDOWSFORMLINQ_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WINDOWSFORMLINQ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET ARITHABORT OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET  MULTI_USER 
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET DB_CHAINING OFF 
GO
USE [WINDOWSFORMLINQ]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 02/08/2021 17:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](20) NULL,
	[Apellido] [varchar](20) NULL,
	[Edad] [int] NULL,
	[casado] [bit] NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[empleados] ([ID], [Nombre], [Apellido], [Edad], [casado]) VALUES (1, N'Ana', N'Gotor', 32, 1)
GO
/****** Object:  Index [IX_empleados]    Script Date: 02/08/2021 17:05:42 ******/
CREATE NONCLUSTERED INDEX [IX_empleados] ON [dbo].[empleados]
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [WINDOWSFORMLINQ] SET  READ_WRITE 
GO
