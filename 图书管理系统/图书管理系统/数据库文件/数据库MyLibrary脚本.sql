USE [MyLibrary]
GO
/****** Object:  Table [dbo].[LoginRecord]    Script Date: 12/07/2012 09:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibraryUser]    Script Date: 12/07/2012 09:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryUser](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](max) NULL,
	[userPassword] [nvarchar](max) NULL,
	[times] [int] NULL,
	[sex] [nvarchar](max) NULL,
 CONSTRAINT [PK_LibraryUser] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibraryRecord]    Script Date: 12/07/2012 09:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](max) NULL,
	[ISBN号] [int] NULL,
	[书名] [nvarchar](max) NULL,
	[借书日期] [nvarchar](max) NULL,
 CONSTRAINT [PK_LibraryRecord] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibraryAdmin]    Script Date: 12/07/2012 09:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibraryAdmin](
	[adminID] [int] IDENTITY(1,1) NOT NULL,
	[adminName] [nvarchar](max) NULL,
	[adminPassword] [nvarchar](50) NULL,
	[times] [int] NULL,
 CONSTRAINT [PK_LibraryAdmin] PRIMARY KEY CLUSTERED 
(
	[adminID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 12/07/2012 09:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN号] [int] IDENTITY(1,1) NOT NULL,
	[书名] [nvarchar](max) NULL,
	[作者] [nvarchar](max) NULL,
	[图书类别] [nvarchar](max) NULL,
	[出版日期] [nvarchar](max) NULL,
	[内容摘要] [nvarchar](max) NULL,
	[出版社] [nvarchar](max) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ISBN号] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_LibraryAdmin_times]    Script Date: 12/07/2012 09:20:21 ******/
ALTER TABLE [dbo].[LibraryAdmin] ADD  CONSTRAINT [DF_LibraryAdmin_times]  DEFAULT ((0)) FOR [times]
GO
/****** Object:  Default [DF_LibraryUser_sex]    Script Date: 12/07/2012 09:20:21 ******/
ALTER TABLE [dbo].[LibraryUser] ADD  CONSTRAINT [DF_LibraryUser_sex]  DEFAULT ('男') FOR [sex]
GO
