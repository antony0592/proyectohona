USE [master]
GO
/****** Object:  Database [dbhotelhona]    Script Date: 2/6/2020 21:04:57 ******/
CREATE DATABASE [dbhotelhona]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbhotelhona', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbhotelhona.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbhotelhona_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dbhotelhona_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbhotelhona] SET COMPATIBILITY_LEVEL = 150
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
EXEC sys.sp_db_vardecimal_storage_format N'dbhotelhona', N'ON'
GO
ALTER DATABASE [dbhotelhona] SET QUERY_STORE = OFF
GO
USE [dbhotelhona]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2/6/2020 21:04:57 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbclient]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbcontentpage]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbhotel]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbpaymentcard]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbpaymentcard](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idclient] [int] NOT NULL,
	[cvv] [numeric](4, 0) NOT NULL,
	[type] [varchar](15) NOT NULL,
	[number] [bigint] NULL,
	[date] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbreservation]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbreservation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idroom] [int] NOT NULL,
	[idclient] [int] NOT NULL,
	[arrivaldate] [datetime] NOT NULL,
	[departuredate] [datetime] NOT NULL,
	[creationdate] [datetime] NULL,
	[amount] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbroom]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbtyperoom]    Script Date: 2/6/2020 21:04:58 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 2/6/2020 21:04:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 2/6/2020 21:04:58 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 2/6/2020 21:04:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 2/6/2020 21:04:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 2/6/2020 21:04:58 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 2/6/2020 21:04:58 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 2/6/2020 21:04:58 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddClient]
@identification numeric(15,0), @name varchar(50),@lastname varchar(50),@email varchar(50)
as
begin

insert into tbclient (identification,name,lastname,email)
values (@identification,@name,@lastname,@email)

select * from tbclient
where id= (SELECT SCOPE_IDENTITY())
end
GO
/****** Object:  StoredProcedure [dbo].[AddPaymentCard]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddPaymentCard]
@number BIGINT, @idclient INT,@date varchar(30),@cvv numeric(4,0),@type varchar(15)
as
begin

insert into [dbo].[tbpaymentcard](number,idclient,date,cvv,type)
values (@number,@idclient,@date,@cvv,@type)

end
GO
/****** Object:  StoredProcedure [dbo].[AddReservation]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddReservation]
	@idroom int, 
	@idclient int,
	@amount decimal,
	@arrivaldate datetime,
	@departuredate datetime,
	@creationdate datetime
as
begin

insert into tbreservation(
	idroom, 
	idclient,
	amount,
	arrivaldate,
	departuredate,
	creationdate)
values (
	@idroom, 
	@idclient,
	@amount,
	@arrivaldate,
	@departuredate,
	@creationdate)

end
GO
/****** Object:  StoredProcedure [dbo].[GetTypeRoomByIdRoom]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetTypeRoomByIdRoom]
@id int
AS 
  BEGIN 
	select tbtyperoom.id,quantityperson,quantitybed,description,amount,urlimage,descriptiontyperoom
	from tbtyperoom
	inner join tbroom
	on tbtyperoom.id = tbroom.idtyperoom
	where tbroom.id=@id
END 
GO
/****** Object:  StoredProcedure [dbo].[SearchAvailability]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchAvailability]  
@arrivaldate DATE,  @departuredate DATE , @typeroom INT 
AS  
BEGIN 
	BEGIN TRY

	/*CALCULA LOS DÍAS PARA CALCULAR LA TARIFA*/
	DECLARE @days INT; 
	SET @days = DATEDIFF(day, @arrivaldate, @departuredate);

	/*SELECCIONA TODOS LOS DE TIPO DE HABITACIÓN DADO*/
	SELECT tbroom.number, tbtyperoom.description AS 'typeroom', tbtyperoom.amount*@days AS 'amount' FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	WHERE tbroom.idtyperoom=@typeroom AND tbroom.state=1

	EXCEPT

	/*SELECCIONA LOS QUE ESTÁN OCUPADOS ENTRE ESAS FECHAS*/
	SELECT tbroom.number, tbtyperoom.description AS 'typeroom', tbtyperoom.amount*@days FROM tbroom
	INNER JOIN tbtyperoom ON tbtyperoom.id = tbroom.idtyperoom
	INNER JOIN tbreservation ON tbreservation.idroom=tbroom.id
	WHERE @arrivaldate <= tbreservation.arrivaldate AND @departuredate >= tbreservation.departuredate 
	
	
	END TRY
	BEGIN CATCH
		print 'Hubo error en el procedimiento'
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SearchRoom]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SearchRoomRecomendation]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectClient]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectContentPage]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectHotel]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectPaymentcard]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SelectPaymentcard] 
AS 
  BEGIN 
      SELECT * 
      FROM tbpaymentcard; 
END 
GO
/****** Object:  StoredProcedure [dbo].[SelectPublicity]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectReservation]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SelectReservation] 
AS 
  BEGIN 
      SELECT id,idroom,idclient,arrivaldate,departuredate,creationdate,amount
      FROM tbreservation; 
END 
GO
/****** Object:  StoredProcedure [dbo].[SelectReservation_today]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectReservation_today] 
AS 
  BEGIN 
      SELECT id,idroom,arrivaldate,departuredate,creationdate,amount
      FROM tbreservation 
	  where arrivaldate=getdate()
END 

GO
/****** Object:  StoredProcedure [dbo].[SelectRole]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectRoom]    Script Date: 2/6/2020 21:04:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SelectRoom] 
AS 
  BEGIN 
      SELECT * 
      FROM tbroom; 
END 
GO
/****** Object:  StoredProcedure [dbo].[SelectTypeRoom]    Script Date: 2/6/2020 21:04:58 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateTypeRoom]    Script Date: 2/6/2020 21:04:58 ******/
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
