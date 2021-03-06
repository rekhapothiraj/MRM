
USE [MRM]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/15/2012 10:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Site]    Script Date: 12/15/2012 10:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Site](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Site] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Site] ON
INSERT [dbo].[Site] ([Id], [Name]) VALUES (1, N'Saxon House')
INSERT [dbo].[Site] ([Id], [Name]) VALUES (2, N'Pegasus House')
SET IDENTITY_INSERT [dbo].[Site] OFF
/****** Object:  Table [dbo].[MeetingRoom]    Script Date: 12/15/2012 10:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MeetingRoom](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[SiteId] [int] NOT NULL,
 CONSTRAINT [PK_MeetingRoom] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 12/15/2012 10:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[MeetingRoomId] [int] NOT NULL, 
	[Date] [datetime] NOT NULL,
	[FromTime] [datetime] NOT NULL,
	[ToTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Booking_User]    Script Date: 12/15/2012 10:43:10 ******/
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_User]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_MeetingRoom] FOREIGN KEY([MeetingRoomId])
REFERENCES [dbo].[MeetingRoom] ([Id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_MeetingRoom]
GO

/****** Object:  ForeignKey [FK_MeetingRoom_Site]    Script Date: 12/15/2012 10:43:10 ******/
ALTER TABLE [dbo].[MeetingRoom]  WITH CHECK ADD  CONSTRAINT [FK_MeetingRoom_Site] FOREIGN KEY([SiteId])
REFERENCES [dbo].[Site] ([Id])
GO
ALTER TABLE [dbo].[MeetingRoom] CHECK CONSTRAINT [FK_MeetingRoom_Site]
GO
