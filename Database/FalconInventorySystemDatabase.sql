USE [master]
GO
/****** Object:  Database [FalconInventorySystem]    Script Date: 17/10/2021 7:51:20 p. m. ******/
CREATE DATABASE [FalconInventorySystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FalconInventorySystem', FILENAME = N'C:\Users\juane\FalconInventorySystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FalconInventorySystem_log', FILENAME = N'C:\Users\juane\FalconInventorySystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FalconInventorySystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FalconInventorySystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FalconInventorySystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FalconInventorySystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FalconInventorySystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FalconInventorySystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FalconInventorySystem] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [FalconInventorySystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FalconInventorySystem] SET  MULTI_USER 
GO
ALTER DATABASE [FalconInventorySystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FalconInventorySystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FalconInventorySystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FalconInventorySystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FalconInventorySystem] SET DELAYED_DURABILITY = DISABLED 
GO
USE [FalconInventorySystem]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17/10/2021 7:51:21 p. m. ******/
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
/****** Object:  Table [dbo].[BillOrderItems]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillOrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[BillOrderId] [int] NOT NULL,
	[StateId] [int] NULL,
	[Observation] [nvarchar](500) NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_BillOrderItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BillOrders]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderCreationDate] [datetime2](7) NOT NULL,
	[Client] [nvarchar](100) NOT NULL,
	[Observation] [nvarchar](500) NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_BillOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Brands]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](50) NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemTransactions]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemTransactions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransactionDate] [datetime2](7) NOT NULL,
	[Amount] [int] NULL,
	[PurchaseOrderItemId] [int] NULL,
	[WarehouseId] [int] NULL,
	[BillOrderItemId] [int] NULL,
	[Observation] [nvarchar](500) NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_ItemTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[BrandId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseOrderItems]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[UnitValue] [float] NOT NULL,
	[PurchaseOrderId] [int] NOT NULL,
	[StateId] [int] NULL,
	[Observation] [nvarchar](500) NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_PurchaseOrderItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseOrders]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NumberOrder] [nvarchar](20) NOT NULL,
	[OrderCreationDate] [datetime2](7) NOT NULL,
	[SupplierId] [int] NOT NULL,
	[Observation] [nvarchar](500) NULL,
	[Tax] [float] NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_PurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](100) NOT NULL,
	[Nit] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TransactionStates]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionStates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](50) NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_TransactionStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Warehouses]    Script Date: 17/10/2021 7:51:21 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaximumCapacity] [float] NOT NULL,
	[MinimumCapacity] [float] NOT NULL,
	[Observation] [nvarchar](500) NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[ModificationDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Warehouses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211016040459_TablesCreated', N'5.0.0')
SET IDENTITY_INSERT [dbo].[BillOrderItems] ON 

INSERT [dbo].[BillOrderItems] ([Id], [ProductId], [Amount], [BillOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (4, 2, 10, 4, 2, N'NA', CAST(N'2021-10-16 21:40:18.5194833' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[BillOrderItems] ([Id], [ProductId], [Amount], [BillOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (6, 1, 100, 4, 5, N'NA', CAST(N'2021-10-17 19:38:50.3951873' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[BillOrderItems] OFF
SET IDENTITY_INSERT [dbo].[BillOrders] ON 

INSERT [dbo].[BillOrders] ([Id], [OrderCreationDate], [Client], [Observation], [CreationDate], [ModificationDate]) VALUES (4, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'NA', N'NA', CAST(N'2021-10-16 21:40:09.5491292' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[BillOrders] ([Id], [OrderCreationDate], [Client], [Observation], [CreationDate], [ModificationDate]) VALUES (5, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), N'Juanes', N'NA', CAST(N'2021-10-17 14:52:30.1227991' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[BillOrders] OFF
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([Id], [BrandName], [CreationDate], [ModificationDate]) VALUES (1, N'Marca1', CAST(N'2021-10-15 23:12:20.9926221' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [CategoryName], [CreationDate], [ModificationDate]) VALUES (1, N'Categoría1', CAST(N'2021-10-15 23:12:30.4908983' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[ItemTransactions] ON 

INSERT [dbo].[ItemTransactions] ([Id], [TransactionDate], [Amount], [PurchaseOrderItemId], [WarehouseId], [BillOrderItemId], [Observation], [CreationDate], [ModificationDate]) VALUES (3, CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), 10, 12, 1, NULL, NULL, CAST(N'2021-10-17 17:25:33.2210580' AS DateTime2), CAST(N'2021-10-17 19:35:36.8969645' AS DateTime2))
INSERT [dbo].[ItemTransactions] ([Id], [TransactionDate], [Amount], [PurchaseOrderItemId], [WarehouseId], [BillOrderItemId], [Observation], [CreationDate], [ModificationDate]) VALUES (4, CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), 150, NULL, 1, 6, N'NA', CAST(N'2021-10-17 19:39:21.5818503' AS DateTime2), CAST(N'2021-10-17 19:39:42.3525577' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ItemTransactions] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [ProductName], [Description], [BrandId], [CategoryId], [CreationDate], [ModificationDate]) VALUES (1, N'Producto1', N'NA', 1, 1, CAST(N'2021-10-15 23:12:42.9553536' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Products] ([Id], [ProductName], [Description], [BrandId], [CategoryId], [CreationDate], [ModificationDate]) VALUES (2, N'Producto2', N'NA', 1, 1, CAST(N'2021-10-15 23:42:14.7102207' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[PurchaseOrderItems] ON 

INSERT [dbo].[PurchaseOrderItems] ([Id], [ProductId], [Amount], [UnitValue], [PurchaseOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (12, 1, 100, 1, 4, 6, N'NA', CAST(N'2021-10-16 00:05:58.5191902' AS DateTime2), CAST(N'2021-10-17 19:36:06.2461364' AS DateTime2))
INSERT [dbo].[PurchaseOrderItems] ([Id], [ProductId], [Amount], [UnitValue], [PurchaseOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (13, 2, 1, 1, 4, 2, N'NA', CAST(N'2021-10-16 00:06:09.8378760' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrderItems] ([Id], [ProductId], [Amount], [UnitValue], [PurchaseOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (14, 1, 1, 1, 4, 2, N'NA', CAST(N'2021-10-16 00:06:24.0080418' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrderItems] ([Id], [ProductId], [Amount], [UnitValue], [PurchaseOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (17, 1, 1, 1, 5, 2, N'NA', CAST(N'2021-10-16 16:01:06.2750764' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrderItems] ([Id], [ProductId], [Amount], [UnitValue], [PurchaseOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (18, 2, 12, 25, 5, 2, N'na', CAST(N'2021-10-16 16:01:31.3253728' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrderItems] ([Id], [ProductId], [Amount], [UnitValue], [PurchaseOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (20, 1, 1, 10000, 6, 2, N'NA', CAST(N'2021-10-16 18:39:08.8612555' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrderItems] ([Id], [ProductId], [Amount], [UnitValue], [PurchaseOrderId], [StateId], [Observation], [CreationDate], [ModificationDate]) VALUES (22, 1, 10, 100, 4, 2, N'NA', CAST(N'2021-10-17 19:34:33.3074146' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PurchaseOrderItems] OFF
SET IDENTITY_INSERT [dbo].[PurchaseOrders] ON 

INSERT [dbo].[PurchaseOrders] ([Id], [NumberOrder], [OrderCreationDate], [SupplierId], [Observation], [Tax], [CreationDate], [ModificationDate]) VALUES (4, N'A1', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 1, N'NA', 1, CAST(N'2021-10-16 00:01:27.2544619' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrders] ([Id], [NumberOrder], [OrderCreationDate], [SupplierId], [Observation], [Tax], [CreationDate], [ModificationDate]) VALUES (5, N'A01', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 1, N'NA', 1, CAST(N'2021-10-16 16:00:48.2942457' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrders] ([Id], [NumberOrder], [OrderCreationDate], [SupplierId], [Observation], [Tax], [CreationDate], [ModificationDate]) VALUES (6, N'A22', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 1, N'NA', 0, CAST(N'2021-10-16 18:38:57.0935728' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[PurchaseOrders] ([Id], [NumberOrder], [OrderCreationDate], [SupplierId], [Observation], [Tax], [CreationDate], [ModificationDate]) VALUES (7, N'A1', CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2), 1, N'NA', 1, CAST(N'2021-10-17 14:51:46.2252248' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[PurchaseOrders] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([Id], [SupplierName], [Nit], [Address], [Phone], [Email], [CreationDate], [ModificationDate]) VALUES (1, N'Prov1', N'NIT1', N'DIR1', N'TEL1', N'prov1@mai.com', CAST(N'2021-10-15 23:12:06.6752371' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
SET IDENTITY_INSERT [dbo].[TransactionStates] ON 

INSERT [dbo].[TransactionStates] ([Id], [StateName], [CreationDate], [ModificationDate]) VALUES (2, N'Creado', CAST(N'2021-10-15 00:00:00.0000000' AS DateTime2), CAST(N'2021-10-15 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TransactionStates] ([Id], [StateName], [CreationDate], [ModificationDate]) VALUES (3, N'Bodega', CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TransactionStates] ([Id], [StateName], [CreationDate], [ModificationDate]) VALUES (4, N'Salida', CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TransactionStates] ([Id], [StateName], [CreationDate], [ModificationDate]) VALUES (5, N'Problemas salida', CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TransactionStates] ([Id], [StateName], [CreationDate], [ModificationDate]) VALUES (6, N'Incompleto bodeda', CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TransactionStates] ([Id], [StateName], [CreationDate], [ModificationDate]) VALUES (7, N'Incompleto salida', CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TransactionStates] ([Id], [StateName], [CreationDate], [ModificationDate]) VALUES (8, N'Problemas bodega', CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2), CAST(N'2021-10-17 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TransactionStates] OFF
SET IDENTITY_INSERT [dbo].[Warehouses] ON 

INSERT [dbo].[Warehouses] ([Id], [MaximumCapacity], [MinimumCapacity], [Observation], [CreationDate], [ModificationDate]) VALUES (1, 100, 5, N'NA', CAST(N'2021-10-17 14:59:27.7656178' AS DateTime2), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Warehouses] OFF
/****** Object:  Index [IX_BillOrderItems_BillOrderId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_BillOrderItems_BillOrderId] ON [dbo].[BillOrderItems]
(
	[BillOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BillOrderItems_ProductId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_BillOrderItems_ProductId] ON [dbo].[BillOrderItems]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BillOrderItems_StateId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_BillOrderItems_StateId] ON [dbo].[BillOrderItems]
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemTransactions_BillOrderItemId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ItemTransactions_BillOrderItemId] ON [dbo].[ItemTransactions]
(
	[BillOrderItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemTransactions_PurchaseOrderItemId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ItemTransactions_PurchaseOrderItemId] ON [dbo].[ItemTransactions]
(
	[PurchaseOrderItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ItemTransactions_WarehouseId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ItemTransactions_WarehouseId] ON [dbo].[ItemTransactions]
(
	[WarehouseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_BrandId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Products_BrandId] ON [dbo].[Products]
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurchaseOrderItems_ProductId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_PurchaseOrderItems_ProductId] ON [dbo].[PurchaseOrderItems]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurchaseOrderItems_PurchaseOrderId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_PurchaseOrderItems_PurchaseOrderId] ON [dbo].[PurchaseOrderItems]
(
	[PurchaseOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurchaseOrderItems_StateId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_PurchaseOrderItems_StateId] ON [dbo].[PurchaseOrderItems]
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurchaseOrders_SupplierId]    Script Date: 17/10/2021 7:51:21 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_PurchaseOrders_SupplierId] ON [dbo].[PurchaseOrders]
(
	[SupplierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BillOrderItems]  WITH CHECK ADD  CONSTRAINT [FK_BillOrderItems_BillOrders_BillOrderId] FOREIGN KEY([BillOrderId])
REFERENCES [dbo].[BillOrders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillOrderItems] CHECK CONSTRAINT [FK_BillOrderItems_BillOrders_BillOrderId]
GO
ALTER TABLE [dbo].[BillOrderItems]  WITH CHECK ADD  CONSTRAINT [FK_BillOrderItems_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillOrderItems] CHECK CONSTRAINT [FK_BillOrderItems_Products_ProductId]
GO
ALTER TABLE [dbo].[BillOrderItems]  WITH CHECK ADD  CONSTRAINT [FK_BillOrderItems_TransactionStates_StateId] FOREIGN KEY([StateId])
REFERENCES [dbo].[TransactionStates] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillOrderItems] CHECK CONSTRAINT [FK_BillOrderItems_TransactionStates_StateId]
GO
ALTER TABLE [dbo].[ItemTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ItemTransactions_BillOrderItems_BillOrderItemId] FOREIGN KEY([BillOrderItemId])
REFERENCES [dbo].[BillOrderItems] ([Id])
GO
ALTER TABLE [dbo].[ItemTransactions] CHECK CONSTRAINT [FK_ItemTransactions_BillOrderItems_BillOrderItemId]
GO
ALTER TABLE [dbo].[ItemTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ItemTransactions_PurchaseOrderItems_PurchaseOrderItemId] FOREIGN KEY([PurchaseOrderItemId])
REFERENCES [dbo].[PurchaseOrderItems] ([Id])
GO
ALTER TABLE [dbo].[ItemTransactions] CHECK CONSTRAINT [FK_ItemTransactions_PurchaseOrderItems_PurchaseOrderItemId]
GO
ALTER TABLE [dbo].[ItemTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ItemTransactions_Warehouses_WarehouseId] FOREIGN KEY([WarehouseId])
REFERENCES [dbo].[Warehouses] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ItemTransactions] CHECK CONSTRAINT [FK_ItemTransactions_Warehouses_WarehouseId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands_BrandId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[PurchaseOrderItems]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderItems_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrderItems] CHECK CONSTRAINT [FK_PurchaseOrderItems_Products_ProductId]
GO
ALTER TABLE [dbo].[PurchaseOrderItems]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderItems_PurchaseOrders_PurchaseOrderId] FOREIGN KEY([PurchaseOrderId])
REFERENCES [dbo].[PurchaseOrders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrderItems] CHECK CONSTRAINT [FK_PurchaseOrderItems_PurchaseOrders_PurchaseOrderId]
GO
ALTER TABLE [dbo].[PurchaseOrderItems]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrderItems_TransactionStates_StateId] FOREIGN KEY([StateId])
REFERENCES [dbo].[TransactionStates] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrderItems] CHECK CONSTRAINT [FK_PurchaseOrderItems_TransactionStates_StateId]
GO
ALTER TABLE [dbo].[PurchaseOrders]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrders_Suppliers_SupplierId] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseOrders] CHECK CONSTRAINT [FK_PurchaseOrders_Suppliers_SupplierId]
GO
USE [master]
GO
ALTER DATABASE [FalconInventorySystem] SET  READ_WRITE 
GO
