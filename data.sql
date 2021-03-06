USE [Movie]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/18/2020 10:49:34 AM ******/
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
/****** Object:  Table [dbo].[DatVes]    Script Date: 12/18/2020 10:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatVes](
	[sdt] [nvarchar](450) NOT NULL,
	[tenrap] [nvarchar](max) NULL,
	[sove] [nvarchar](max) NULL,
 CONSTRAINT [PK_DatVes] PRIMARY KEY CLUSTERED 
(
	[sdt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichChieus]    Script Date: 12/18/2020 10:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichChieus](
	[idLC] [nvarchar](450) NOT NULL,
	[tenphim] [nvarchar](max) NULL,
	[tenrap] [nvarchar](max) NULL,
	[giochieu] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_LichChieus] PRIMARY KEY CLUSTERED 
(
	[idLC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phims]    Script Date: 12/18/2020 10:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phims](
	[tenphim] [nvarchar](450) NOT NULL,
	[thoiluong] [nvarchar](max) NULL,
 CONSTRAINT [PK_Phims] PRIMARY KEY CLUSTERED 
(
	[tenphim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raps]    Script Date: 12/18/2020 10:49:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raps](
	[tenrap] [nvarchar](450) NOT NULL,
	[chotrong] [int] NOT NULL,
 CONSTRAINT [PK_Raps] PRIMARY KEY CLUSTERED 
(
	[tenrap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
