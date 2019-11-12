﻿USE [master]
GO

CREATE DATABASE [ForumExample]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ForumExample', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ForumExample.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ForumExample_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ForumExample_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ForumExample] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ForumExample].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ForumExample] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ForumExample] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ForumExample] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ForumExample] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ForumExample] SET ARITHABORT OFF 
GO

ALTER DATABASE [ForumExample] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ForumExample] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [ForumExample] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ForumExample] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ForumExample] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ForumExample] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ForumExample] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ForumExample] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ForumExample] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ForumExample] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ForumExample] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ForumExample] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ForumExample] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ForumExample] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ForumExample] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ForumExample] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ForumExample] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ForumExample] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ForumExample] SET RECOVERY FULL 
GO

ALTER DATABASE [ForumExample] SET  MULTI_USER 
GO

ALTER DATABASE [ForumExample] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ForumExample] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ForumExample] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ForumExample] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ForumExample] SET  READ_WRITE 
GO

