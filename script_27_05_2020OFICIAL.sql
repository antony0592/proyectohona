USE [master]
GO
/****** Object:  Database [dbhotelhona]    Script Date: 27/05/2020 09:12:38  ******/
CREATE DATABASE [dbhotelhona]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbhotelhona', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbhotelhona.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'dbhotelhona_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbhotelhona_log.ldf' , SIZE = 1792KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbhotelhona] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbhotelhona].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbhotelhona] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbhotelhona] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbhotelhona] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbhotelhona] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbhotelhona] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbhotelhona] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbhotelhona] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbhotelhona] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbhotelhona] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbhotelhona] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbhotelhona] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbhotelhona] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbhotelhona] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbhotelhona] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbhotelhona] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbhotelhona] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbhotelhona] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbhotelhona] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbhotelhona] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbhotelhona] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbhotelhona] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbhotelhona] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbhotelhona] SET RECOVERY FULL 
GO
ALTER DATABASE [dbhotelhona] SET  MULTI_USER 
GO
ALTER DATABASE [dbhotelhona] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbhotelhona] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbhotelhona] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbhotelhona] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbhotelhona] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbhotelhona] SET QUERY_STORE = OFF
GO
USE [dbhotelhona]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [dbhotelhona]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbclient]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbclient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[identification] [numeric](15, 0) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastname] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbcontentpage]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbcontentpage](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[referentpage] [varchar](30) NOT NULL,
	[urlimage] [varchar](100) NOT NULL,
	[typeimage] [varchar](20) NOT NULL,
	[content] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbhotel]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbhotel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[description] [nvarchar](max) NULL,
	[aboutus] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[pobox] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbpaymentcard]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbpaymentcard](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [int] NOT NULL,
	[idclient] [int] NOT NULL,
	[date] [datetime] NOT NULL,
	[cvv] [numeric](4, 0) NOT NULL,
	[type] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbreservation]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbreservation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idroom] [int] NOT NULL,
	[idclient] [int] NOT NULL,
	[amount] [decimal](6, 2) NOT NULL,
	[arrivaldate] [datetime] NOT NULL,
	[departuredate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbroom]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbroom](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idtyperoom] [int] NOT NULL,
	[state] [numeric](1, 0) NOT NULL,
	[number] [numeric](2, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbtyperoom]    Script Date: 27/05/2020 09:12:38  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbtyperoom](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[quantityperson] [numeric](2, 0) NOT NULL,
	[quantitybed] [numeric](2, 0) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[amount] [int] NOT NULL,
	[urlimage] [varchar](100) NULL,
	[descriptiontyperoom] [varchar](400) NULL,
 CONSTRAINT [PK__tbtypero__3213E83FCB8FFAD6] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.1.14-servicing-32113')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'375d0b87-205b-4073-818d-da0025b75df2', N'Admin', N'ADMIN', N'8ced0b53-4fb6-4e13-ae54-3d7b01f15d52')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'609d8ccf-c903-4d6e-acec-33d77ff2bf1a', N'User', N'USER', N'243d9008-7483-43b2-8250-89cd56afea4b')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e880d66b-c751-45bc-b36f-ecae2bc28b9c', N'375d0b87-205b-4073-818d-da0025b75df2')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'04d14f0b-8151-40ca-ad44-5c0b1250c480', N'609d8ccf-c903-4d6e-acec-33d77ff2bf1a')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'04d14f0b-8151-40ca-ad44-5c0b1250c480', N'client@gmail.com', N'CLIENT@GMAIL.COM', N'client@gmail.com', N'CLIENT@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDSWUTBHFqvaM0bjbOMuAI9APxtaTFZNZmAVd9QHX39UZd3Y4f8ow4NN9FdrZvrh0w==', N'CXG27ZVD5QUX3Y7DHVNKPITUB6IRBBHI', N'6f5a9bf4-5ba7-448c-b12e-c9353aed9942', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e880d66b-c751-45bc-b36f-ecae2bc28b9c', N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 1, N'AQAAAAEAACcQAAAAENourBIP2FzAuwzi75F3Isqa4oJrYogQlm130xaE6/9QKZvtPUdORm8huCNyXAt7LA==', N'2VTQ6QKUHOTAXAU76SAAP5GAAVYSDZU4', N'fc59b622-a092-4f34-babf-c450e41904ad', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[tbclient] ON 

INSERT [dbo].[tbclient] ([id], [identification], [name], [lastname], [email]) VALUES (1, CAST(0 AS Numeric(15, 0)), N'System', N'Admin', N'system@admin.com')
INSERT [dbo].[tbclient] ([id], [identification], [name], [lastname], [email]) VALUES (2, CAST(1 AS Numeric(15, 0)), N'Anthony', N'Salazar Araya', N'asalazar0592@gmail.com')
SET IDENTITY_INSERT [dbo].[tbclient] OFF
SET IDENTITY_INSERT [dbo].[tbcontentpage] ON 

INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (1, N'facility', N'/images/Facilidades/facilidad-06.jpg', N'1', N'El hotel ofrece conserje, para que tu estancia sea incluso más agradable. El establecimiento también cuenta con piscina y desayuno incluido. Los huéspedes que lleguen en coche tienen acceso a parking gratis.Mientras estás aquí, asegúrate de ir a restaurantes de marisco como Costa Coral Restaurant, Mar y Sol y Cristobal Restaurant, que se encuentran cerca de Tango Mar Beachfront Boutique Hotel & Villas.Hotel Patito está deseando darte la bienvenida cuando visites la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (2, N'facility', N'/images/Facilidades/facilidad-07.jpg', N'1', N'El Hotel Patito también cuenta con recepción abierta las 24 horas, tienda de regalos, instalaciones para practicar deportes acuáticos, punto de venta de forfaits y bar. Hay conexión Wi-Fi gratuita en todas las instalaciones y se facilita aparcamiento privado gratuito. El establecimiento está rodeado por el lago con la presencia imponente de las montañas de la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (3, N'home', N'/images/Hotel_Patito-02.svg', N'2', N'')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (4, N'publicity', N'/images/Publicidad/publicity_01.png', N'1', N'https://www.fifco.com/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (5, N'publicity', N'/images/Publicidad/publicity_02.jpg', N'1', N'https://movistar.cr/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (6, N'publicity', N'/images/Publicidad/publicity_03.gif', N'1', N'www.cocacola.com')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (7, N'facility', N'/images/Galeria/img_03.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (8, N'facility', N'/images/Galeria/img_04.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (9, N'facility', N'/images/Galeria/img_05.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (10, N'facility', N'/images/Galeria/img_06.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (11, N'facility', N'/images/Galeria/img_07.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (12, N'facility', N'/images/Galeria/img_08.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (13, N'facility', N'/images/Facilidades/facilidad-06.jpg', N'1', N'El hotel ofrece conserje, para que tu estancia sea incluso más agradable. El establecimiento también cuenta con piscina y desayuno incluido. Los huéspedes que lleguen en coche tienen acceso a parking gratis.Mientras estás aquí, asegúrate de ir a restaurantes de marisco como Costa Coral Restaurant, Mar y Sol y Cristobal Restaurant, que se encuentran cerca de Tango Mar Beachfront Boutique Hotel & Villas.Hotel Patito está deseando darte la bienvenida cuando visites la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (14, N'facility', N'/images/Facilidades/facilidad-07.jpg', N'1', N'El Hotel Patito también cuenta con recepción abierta las 24 horas, tienda de regalos, instalaciones para practicar deportes acuáticos, punto de venta de forfaits y bar. Hay conexión Wi-Fi gratuita en todas las instalaciones y se facilita aparcamiento privado gratuito. El establecimiento está rodeado por el lago con la presencia imponente de las montañas de la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (15, N'home', N'/images/Hotel_Patito-02.svg', N'2', N'')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (16, N'publicity', N'/images/Publicidad/publicity_01.png', N'1', N'https://www.fifco.com/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (17, N'publicity', N'/images/Publicidad/publicity_02.jpg', N'1', N'https://movistar.cr/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (18, N'publicity', N'/images/Publicidad/publicity_03.gif', N'1', N'www.cocacola.com')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (19, N'facility', N'/images/Galeria/img_03.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (20, N'facility', N'/images/Galeria/img_04.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (21, N'facility', N'/images/Galeria/img_05.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (22, N'facility', N'/images/Galeria/img_06.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (23, N'facility', N'/images/Galeria/img_07.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (24, N'facility', N'/images/Galeria/img_08.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (25, N'facility', N'/images/Facilidades/facilidad-06.jpg', N'1', N'El hotel ofrece conserje, para que tu estancia sea incluso más agradable. El establecimiento también cuenta con piscina y desayuno incluido. Los huéspedes que lleguen en coche tienen acceso a parking gratis.Mientras estás aquí, asegúrate de ir a restaurantes de marisco como Costa Coral Restaurant, Mar y Sol y Cristobal Restaurant, que se encuentran cerca de Tango Mar Beachfront Boutique Hotel & Villas.Hotel Patito está deseando darte la bienvenida cuando visites la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (26, N'facility', N'/images/Facilidades/facilidad-07.jpg', N'1', N'El Hotel Patito también cuenta con recepción abierta las 24 horas, tienda de regalos, instalaciones para practicar deportes acuáticos, punto de venta de forfaits y bar. Hay conexión Wi-Fi gratuita en todas las instalaciones y se facilita aparcamiento privado gratuito. El establecimiento está rodeado por el lago con la presencia imponente de las montañas de la zona.')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (27, N'home', N'/images/Hotel_Patito-02.svg', N'2', N'')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (28, N'publicity', N'/images/Publicidad/publicity_01.png', N'1', N'https://www.fifco.com/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (29, N'publicity', N'/images/Publicidad/publicity_02.jpg', N'1', N'https://movistar.cr/')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (30, N'publicity', N'/images/Publicidad/publicity_03.gif', N'1', N'www.cocacola.com')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (31, N'facility', N'/images/Galeria/img_03.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (32, N'facility', N'/images/Galeria/img_04.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (33, N'facility', N'/images/Galeria/img_05.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (34, N'facility', N'/images/Galeria/img_06.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (35, N'facility', N'/images/Galeria/img_07.jpg', N'2', N'facility')
INSERT [dbo].[tbcontentpage] ([id], [referentpage], [urlimage], [typeimage], [content]) VALUES (36, N'facility', N'/images/Galeria/img_08.jpg', N'2', N'facility')
SET IDENTITY_INSERT [dbo].[tbcontentpage] OFF
SET IDENTITY_INSERT [dbo].[tbhotel] ON 

INSERT [dbo].[tbhotel] ([id], [name], [description], [aboutus], [address], [pobox], [email]) VALUES (15, N'Hotel Patito', N'El hotel Patito dispone de 100 maravillosas habitaciones inspiradas en un estilo propio de la zona y en las que cada espacio tiene su propia y exclusiva personalidad. Gracias a su ubicación en un entorno mágico, los huéspedes podrán descansar en uno de los más bonitos parajes de Costa Rica, escenario natural único en el mundo. Todas ellas cuentan con suelo de baldosa y una decoración elegante, además de disponer de un balcón o terraza con vistas al mar o al jardín. Ofrecemos un ambiente pacífico y ecológicamente equilibrado, donde los huéspedes pueden disfrutar de una estancia sana y tranquila con un ambiente subtropical. El hotel ofrece servicios de alta calidad a un costo razonable y por lo tanto permite a los huéspedes disfrutar de unas vacaciones de ensueño a un precio atractivo.', N'Misión, Visión y Valores
Patito Hotel & Resort es la realización de un sueño cuando se creó la siguiente declaración sobre la misión, visión y valores del resort:
Misión
La misión de la compañía es fomentar una marca única de ecoturismo que expone a los visitantes internacionales y los niños de Costa Rica a las maravillas naturales del país en la forma de un negocio rentable que practica los principios del desarrollo sostenible.
Visión
Para lograr esta misión mientras:
-Lograr y mantener negocios exitosos
-Educar en verdadero ecologismo y ecología
-Invertir en los niños como una inversión en nuestro futuro
-Exhibiendo la belleza natural de Costa Rica

Valores
Los valores de la compañía alcanzarán esta misión al mantener nuestro hotel y asociación con nuestros huéspedes y niños, al exponer a las personas a la importancia de la ecología. El resultado es una relación ganar-ganar para las empresas con respecto al retorno de la inversión y el medio ambiente.»
Haciendo hincapié en la comunidad, la sostenibilidad y el medio ambiente
El hotel pone gran énfasis en mantener el medio ambiente y apoyar a las personas que viven en las pequeñas comunidades en los alrededores del hotel.
También administramos un centro de rescate para animales que brinda refugio a las especies de aves que han resultado heridas.
Consideramos que es nuestra obligación garantizar que tanto la población local como los visitantes internacionales disfruten de la belleza natural y las cualidades del entorno.
El complejo ofrece inmensas oportunidades para educar a los huéspedes y lugareños sobre el medio ambiente.
También apoyamos programas para que los niños aprendan sobre el medio ambiente.
Nuestra compañía tiene una asociación con escuelas en Costa Rica para traer niños a expensas del resort para una experiencia de un día de aprendizaje sobre las maravillas naturales de Costa Rica.
', N'Al salir del aeropuerto, gire a la derecha en 21 y avance 27.6 km (desde Adobe Car Rental, gire a la izquierda en 21 y avance 20.7 km) hacia Belén, donde verá una gran estación de servicio a su derecha.
 
Gire a la derecha en 155 siguiendo las indicaciones hacia Playa Conchal y Reserva Conchal y Westin Hotel.
 
Avance 24.7 km (a 4 km, hay un trote en la carretera en Santa Anna donde gira a la izquierda para continuar por 155 siguiendo las indicaciones hacia Playa Conchal y Westin Hotel)
 
En Huacas, gire a la derecha siguiendo las indicaciones hacia Reserva Conchal y Westin Hotel, a 3.5 km hasta la puerta de seguridad de Reserva Conchal.', N'4006', N'hotelpatito@gmail.com')
SET IDENTITY_INSERT [dbo].[tbhotel] OFF
SET IDENTITY_INSERT [dbo].[tbreservation] ON 

INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (1, 31, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (2, 32, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (3, 33, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (4, 34, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (5, 35, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (6, 36, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (7, 37, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (8, 38, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (9, 39, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (10, 40, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (11, 41, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (12, 42, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (13, 43, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (14, 44, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (15, 45, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (16, 46, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (17, 47, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (18, 48, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (19, 49, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (20, 50, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (21, 51, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (22, 52, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (23, 53, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (24, 54, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (25, 55, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (26, 56, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (27, 57, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (28, 58, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (29, 59, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (30, 60, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (31, 61, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (32, 62, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (33, 63, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (34, 64, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (35, 65, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (36, 66, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (37, 67, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (38, 68, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (39, 69, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (40, 70, 1, CAST(0.00 AS Decimal(6, 2)), CAST(N'2020-05-26T00:00:00.000' AS DateTime), CAST(N'2020-05-26T00:00:00.000' AS DateTime))
INSERT [dbo].[tbreservation] ([id], [idroom], [idclient], [amount], [arrivaldate], [departuredate]) VALUES (50, 42, 2, CAST(30.00 AS Decimal(6, 2)), CAST(N'2020-05-28T00:00:00.000' AS DateTime), CAST(N'2020-05-30T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[tbreservation] OFF
SET IDENTITY_INSERT [dbo].[tbroom] ON 

INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (31, 1, CAST(1 AS Numeric(1, 0)), CAST(1 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (32, 1, CAST(1 AS Numeric(1, 0)), CAST(2 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (33, 1, CAST(1 AS Numeric(1, 0)), CAST(3 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (34, 1, CAST(1 AS Numeric(1, 0)), CAST(4 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (35, 1, CAST(1 AS Numeric(1, 0)), CAST(5 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (36, 1, CAST(1 AS Numeric(1, 0)), CAST(6 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (37, 1, CAST(1 AS Numeric(1, 0)), CAST(7 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (38, 1, CAST(1 AS Numeric(1, 0)), CAST(8 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (39, 1, CAST(1 AS Numeric(1, 0)), CAST(9 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (40, 1, CAST(1 AS Numeric(1, 0)), CAST(10 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (41, 2, CAST(1 AS Numeric(1, 0)), CAST(11 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (42, 2, CAST(1 AS Numeric(1, 0)), CAST(12 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (43, 2, CAST(1 AS Numeric(1, 0)), CAST(13 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (44, 2, CAST(1 AS Numeric(1, 0)), CAST(14 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (45, 2, CAST(1 AS Numeric(1, 0)), CAST(15 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (46, 2, CAST(1 AS Numeric(1, 0)), CAST(16 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (47, 2, CAST(1 AS Numeric(1, 0)), CAST(17 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (48, 2, CAST(1 AS Numeric(1, 0)), CAST(18 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (49, 2, CAST(1 AS Numeric(1, 0)), CAST(19 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (50, 2, CAST(1 AS Numeric(1, 0)), CAST(20 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (51, 3, CAST(1 AS Numeric(1, 0)), CAST(21 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (52, 3, CAST(1 AS Numeric(1, 0)), CAST(22 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (53, 3, CAST(1 AS Numeric(1, 0)), CAST(23 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (54, 3, CAST(1 AS Numeric(1, 0)), CAST(24 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (55, 3, CAST(1 AS Numeric(1, 0)), CAST(25 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (56, 3, CAST(1 AS Numeric(1, 0)), CAST(26 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (57, 3, CAST(1 AS Numeric(1, 0)), CAST(27 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (58, 3, CAST(1 AS Numeric(1, 0)), CAST(28 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (59, 3, CAST(1 AS Numeric(1, 0)), CAST(29 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (60, 3, CAST(1 AS Numeric(1, 0)), CAST(30 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (61, 4, CAST(1 AS Numeric(1, 0)), CAST(21 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (62, 4, CAST(1 AS Numeric(1, 0)), CAST(22 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (63, 4, CAST(1 AS Numeric(1, 0)), CAST(23 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (64, 4, CAST(1 AS Numeric(1, 0)), CAST(24 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (65, 4, CAST(1 AS Numeric(1, 0)), CAST(25 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (66, 4, CAST(1 AS Numeric(1, 0)), CAST(26 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (67, 4, CAST(1 AS Numeric(1, 0)), CAST(27 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (68, 4, CAST(1 AS Numeric(1, 0)), CAST(28 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (69, 4, CAST(1 AS Numeric(1, 0)), CAST(29 AS Numeric(2, 0)))
INSERT [dbo].[tbroom] ([id], [idtyperoom], [state], [number]) VALUES (70, 4, CAST(1 AS Numeric(1, 0)), CAST(30 AS Numeric(2, 0)))
SET IDENTITY_INSERT [dbo].[tbroom] OFF
SET IDENTITY_INSERT [dbo].[tbtyperoom] ON 

INSERT [dbo].[tbtyperoom] ([id], [quantityperson], [quantitybed], [description], [amount], [urlimage], [descriptiontyperoom]) VALUES (1, CAST(2 AS Numeric(2, 0)), CAST(1 AS Numeric(2, 0)), N'Matrimonial', 67, N'/images/TipoHabitacion/ descarga.jpg', N'  Esta bien  ')
INSERT [dbo].[tbtyperoom] ([id], [quantityperson], [quantitybed], [description], [amount], [urlimage], [descriptiontyperoom]) VALUES (2, CAST(1 AS Numeric(2, 0)), CAST(1 AS Numeric(2, 0)), N'Standard', 15000, N'/images/TipoHabitacion/tipohabitacion3.jpeg', N' Habitación con una cama matrimonial, aire acondicionado, TV con cable, abanico de techo y baño privado.  Nueva habitacion')
INSERT [dbo].[tbtyperoom] ([id], [quantityperson], [quantitybed], [description], [amount], [urlimage], [descriptiontyperoom]) VALUES (3, CAST(2 AS Numeric(2, 0)), CAST(1 AS Numeric(2, 0)), N'Junior', 30, N'/images/TipoHabitacion/tipohabitacion2.jpg', N'Suite con balcón o terraza privado, vistas panorámicas del océano, la selva tropical y las montañas')
INSERT [dbo].[tbtyperoom] ([id], [quantityperson], [quantitybed], [description], [amount], [urlimage], [descriptiontyperoom]) VALUES (4, CAST(4 AS Numeric(2, 0)), CAST(2 AS Numeric(2, 0)), N'VIP', 40, N'/images/TipoHabitacion/tipohabitacion3.jpeg', N'Habitaciones de lujo completamente equipadas, diseñadas para brindarle comodidad y conveniencia y permitirle conectarse con el mar y el santuario de vida marina')
SET IDENTITY_INSERT [dbo].[tbtyperoom] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 27/05/2020 09:12:41  ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 27/05/2020 09:12:41  ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 27/05/2020 09:12:41  ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 27/05/2020 09:12:41  ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 27/05/2020 09:12:41  ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 27/05/2020 09:12:41  ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 27/05/2020 09:12:41  ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbpaymentcard] ADD  DEFAULT ((0)) FOR [cvv]
GO
ALTER TABLE [dbo].[tbpaymentcard] ADD  DEFAULT ('CreditCard') FOR [type]
GO
ALTER TABLE [dbo].[tbroom] ADD  DEFAULT ('1') FOR [state]
GO
ALTER TABLE [dbo].[tbroom] ADD  DEFAULT ((0)) FOR [number]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[tbpaymentcard]  WITH CHECK ADD  CONSTRAINT [tbpaymentcard_fk1] FOREIGN KEY([idclient])
REFERENCES [dbo].[tbclient] ([id])
GO
ALTER TABLE [dbo].[tbpaymentcard] CHECK CONSTRAINT [tbpaymentcard_fk1]
GO
ALTER TABLE [dbo].[tbreservation]  WITH CHECK ADD  CONSTRAINT [tbreservation_fk1] FOREIGN KEY([idroom])
REFERENCES [dbo].[tbroom] ([id])
GO
ALTER TABLE [dbo].[tbreservation] CHECK CONSTRAINT [tbreservation_fk1]
GO
ALTER TABLE [dbo].[tbreservation]  WITH CHECK ADD  CONSTRAINT [tbreservation_fk2] FOREIGN KEY([idclient])
REFERENCES [dbo].[tbclient] ([id])
GO
ALTER TABLE [dbo].[tbreservation] CHECK CONSTRAINT [tbreservation_fk2]
GO
ALTER TABLE [dbo].[tbroom]  WITH CHECK ADD  CONSTRAINT [tbroom_fk1] FOREIGN KEY([idtyperoom])
REFERENCES [dbo].[tbtyperoom] ([id])
GO
ALTER TABLE [dbo].[tbroom] CHECK CONSTRAINT [tbroom_fk1]
GO
ALTER TABLE [dbo].[tbcontentpage]  WITH CHECK ADD  CONSTRAINT [CHK_ReferentPage] CHECK  (([referentpage]='home' OR [referentpage]='typeroom' OR [referentpage]='facility' OR [referentpage]='publicity'))
GO
ALTER TABLE [dbo].[tbcontentpage] CHECK CONSTRAINT [CHK_ReferentPage]
GO
/****** Object:  StoredProcedure [dbo].[SearchAvailability]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchAvailability]  
@arrivaldate DATE,  @departuredate DATE , @typeroom INT 
AS  
BEGIN 
	BEGIN TRY

	(SELECT tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.amount
	FROM tbroom INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	WHERE tbroom.idtyperoom=@typeroom AND state=1
	intersect  
	SELECT tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.amount
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	inner join
	tbreservation on tbreservation.idroom=tbroom.id
	where
	@departuredate > tbreservation.departuredate)
	
	/*
	EXCEPT
  
	(SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	WHERE tbroom.idtyperoom!=@typeroom
	and state=1
	intersect  
	SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	inner join
	tbreservation on tbreservation.idroom=tbroom.id
	where
	@arrivaldate <= tbreservation.arrivaldate)

	*/

	END TRY
	BEGIN CATCH
		print 'Hubo error en el procedimiento'
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SearchRoom]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchRoom]  
   @arrivaldate DATE,  @departuredate DATE , @typeroom INT 
AS  
BEGIN 
	BEGIN TRY

	(SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', 
		tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
		INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
		WHERE tbroom.idtyperoom=@typeroom
		AND state=1
	intersect  
	SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	inner join
	tbreservation on tbreservation.idroom=tbroom.id
	where
	@departuredate > tbreservation.departuredate)
	EXCEPT
  
	(SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	WHERE tbroom.idtyperoom=@typeroom
	and state=1
	intersect  
	SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	inner join
	tbreservation on tbreservation.idroom=tbroom.id
	where
	@arrivaldate <= tbreservation.arrivaldate)



	END TRY
	BEGIN CATCH
		print 'Hubo error en el procedimiento'
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SearchRoomRecomendation]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchRoomRecomendation]  
@arrivaldate DATE,  @departuredate DATE , @typeroom INT 
AS  
BEGIN 
	BEGIN TRY

	(SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', 
		tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
		INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
		WHERE tbroom.idtyperoom!=@typeroom
		AND state=1
	intersect  
	SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	inner join
	tbreservation on tbreservation.idroom=tbroom.id
	where
	@departuredate > tbreservation.departuredate)
	EXCEPT
  
	(SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	WHERE tbroom.idtyperoom!=@typeroom
	and state=1
	intersect  
	SELECT tbroom.id, tbroom.idtyperoom,tbroom.state,tbroom.number, tbtyperoom.description as 'typeroom', tbtyperoom.quantityperson, tbtyperoom.quantitybed, tbtyperoom.amount, tbtyperoom.urlimage, tbtyperoom.descriptiontyperoom
	FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	inner join
	tbreservation on tbreservation.idroom=tbroom.id
	where
	@arrivaldate <= tbreservation.arrivaldate)



	END TRY
	BEGIN CATCH
		print 'Hubo error en el procedimiento'
	END CATCH
END
 
GO
/****** Object:  StoredProcedure [dbo].[SelectClient]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectClient] 
AS 
  BEGIN 
      SELECT * 
      FROM tbclient; 
END 
GO
/****** Object:  StoredProcedure [dbo].[SelectContentPage]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectContentPage] 
AS 
  BEGIN 
      SELECT * 
      FROM tbcontentpage; 
END 

GO
/****** Object:  StoredProcedure [dbo].[SelectHotel]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectHotel] 
AS 
  BEGIN 
      SELECT * 
      FROM tbhotel; 
END 
GO
/****** Object:  StoredProcedure [dbo].[SelectPublicity]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectPublicity] 
AS 
  BEGIN 
      SELECT * 
      FROM tbcontentpage where referentpage = 'publicity'; 
END 
GO
/****** Object:  StoredProcedure [dbo].[SelectReservation]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectReservation] 
AS 
  BEGIN 
      SELECT * 
      FROM tbreservation; 
END 
GO
/****** Object:  StoredProcedure [dbo].[SelectRole]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectRole] @role nvarchar(256)
as
begin
	select AspNetUsers.id,AspNetUsers.Email from AspNetUsers
	inner join AspNetUserRoles
	on AspNetUsers.Id=UserId
	inner join AspNetRoles
	on AspNetRoles.Id=RoleId
	where name=@role
end
GO
/****** Object:  StoredProcedure [dbo].[SelectTypeRoom]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectTypeRoom] 
AS 
  BEGIN 
      SELECT * 
      FROM tbtyperoom; 
END 

GO
/****** Object:  StoredProcedure [dbo].[UpdateTypeRoom]    Script Date: 27/05/2020 09:12:41  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTypeRoom]  
@description varchar (400), 
@amount int, 
@urlimage varchar(400), 
@id int
AS 
  BEGIN 
      UPDATE tbtyperoom
		SET amount = @amount, urlimage=@urlimage, descriptiontyperoom=@description
		WHERE id=@id;
END 

GO
USE [master]
GO
ALTER DATABASE [dbhotelhona] SET  READ_WRITE 
GO
