USE [master]
GO
/****** Object:  Database [DentalClinic]    Script Date: 6/26/2023 10:34:54 AM ******/
CREATE DATABASE [DentalClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DentalClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DentalClinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DentalClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DentalClinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DentalClinic] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DentalClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DentalClinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DentalClinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DentalClinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DentalClinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DentalClinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [DentalClinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DentalClinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DentalClinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DentalClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DentalClinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DentalClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DentalClinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DentalClinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DentalClinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DentalClinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DentalClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DentalClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DentalClinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DentalClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DentalClinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DentalClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DentalClinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DentalClinic] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DentalClinic] SET  MULTI_USER 
GO
ALTER DATABASE [DentalClinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DentalClinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DentalClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DentalClinic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DentalClinic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DentalClinic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DentalClinic] SET QUERY_STORE = OFF
GO
USE [DentalClinic]
GO
/****** Object:  Table [dbo].[case_treatment]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[case_treatment](
	[caseId] [int] NOT NULL,
	[treatmentId] [int] NOT NULL,
	[price] [numeric](12, 4) NULL,
 CONSTRAINT [PK_case_treatment] PRIMARY KEY CLUSTERED 
(
	[caseId] ASC,
	[treatmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoneyCheck]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoneyCheck](
	[id] [int] NOT NULL,
	[number] [int] NULL,
	[pid] [int] NULL,
	[pname] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[value] [numeric](12, 4) NULL,
 CONSTRAINT [PK_MoneyCheck] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[outcome]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[outcome](
	[id] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[amount] [numeric](12, 4) NULL,
 CONSTRAINT [PK_outcome] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[id] [int] NOT NULL,
	[name] [varchar](500) NULL,
	[ssn] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[birthDay] [varchar](50) NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientCase]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientCase](
	[id] [int] NOT NULL,
	[pid] [int] NULL,
	[pname] [varchar](150) NULL,
	[cost] [numeric](12, 4) NULL,
	[date] [varchar](50) NULL,
	[notes] [text] NULL,
 CONSTRAINT [PK_Case] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payment]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payment](
	[id] [int] NOT NULL,
	[pid] [int] NOT NULL,
	[pname] [varchar](500) NULL,
	[date] [varchar](50) NULL,
	[amount] [numeric](12, 4) NULL,
 CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Treatment]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatment](
	[id] [int] NOT NULL,
	[name] [varchar](500) NULL,
	[minprice] [numeric](12, 4) NULL,
	[middelprice] [numeric](12, 4) NULL,
	[maxprice] [numeric](12, 4) NULL,
 CONSTRAINT [PK_Treatment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TreatmentPlan]    Script Date: 6/26/2023 10:34:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreatmentPlan](
	[id] [int] NOT NULL,
	[pid] [int] NULL,
	[description] [text] NULL,
	[xrayImage] [image] NULL,
 CONSTRAINT [PK_TreatmentPlan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[case_treatment]  WITH CHECK ADD  CONSTRAINT [FK_CASEID] FOREIGN KEY([caseId])
REFERENCES [dbo].[PatientCase] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[case_treatment] CHECK CONSTRAINT [FK_CASEID]
GO
ALTER TABLE [dbo].[case_treatment]  WITH CHECK ADD  CONSTRAINT [FK_TREATMENTID] FOREIGN KEY([treatmentId])
REFERENCES [dbo].[Treatment] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[case_treatment] CHECK CONSTRAINT [FK_TREATMENTID]
GO
ALTER TABLE [dbo].[MoneyCheck]  WITH CHECK ADD  CONSTRAINT [FK_PID] FOREIGN KEY([pid])
REFERENCES [dbo].[patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MoneyCheck] CHECK CONSTRAINT [FK_PID]
GO
ALTER TABLE [dbo].[PatientCase]  WITH CHECK ADD  CONSTRAINT [FK_PATIENTCASE] FOREIGN KEY([pid])
REFERENCES [dbo].[patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PatientCase] CHECK CONSTRAINT [FK_PATIENTCASE]
GO
ALTER TABLE [dbo].[payment]  WITH CHECK ADD  CONSTRAINT [FK_PATIENT_PAYMENT] FOREIGN KEY([pid])
REFERENCES [dbo].[patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[payment] CHECK CONSTRAINT [FK_PATIENT_PAYMENT]
GO
ALTER TABLE [dbo].[TreatmentPlan]  WITH CHECK ADD  CONSTRAINT [FK_PID_IN_PLAN] FOREIGN KEY([pid])
REFERENCES [dbo].[patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TreatmentPlan] CHECK CONSTRAINT [FK_PID_IN_PLAN]
GO
USE [master]
GO
ALTER DATABASE [DentalClinic] SET  READ_WRITE 
GO
