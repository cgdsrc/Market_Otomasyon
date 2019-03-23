USE [master]
GO

/****** Object:  Database [Market]    Script Date: 29.01.2019 14:09:12 ******/
CREATE DATABASE [Market]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Market', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Market.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Market_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Market_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Market] SET COMPATIBILITY_LEVEL = 140
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Market].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Market] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Market] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Market] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Market] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Market] SET ARITHABORT OFF 
GO

ALTER DATABASE [Market] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Market] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Market] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Market] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Market] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Market] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Market] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Market] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Market] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Market] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Market] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Market] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Market] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Market] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Market] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Market] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Market] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Market] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Market] SET  MULTI_USER 
GO

ALTER DATABASE [Market] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Market] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Market] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Market] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Market] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Market] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Market] SET  READ_WRITE 
GO
