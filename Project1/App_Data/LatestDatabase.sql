

CREATE TABLE [dbo].[Clients](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[MobileNumber] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Region] [varchar](50) NULL,
	[JoinDate] [date] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


CREATE TABLE [dbo].[Workers](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[MobileNumber] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Category] [varchar](max) NULL,
	[Description] [varchar](max) NULL,
	[Region] [varchar](50) NULL,
	[JoinDate] [date] NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[AdTable](
	[PostAdId] [int] IDENTITY(1,1) NOT NULL,
	[AdTitle] [varchar](50) NULL,
	[AdDescription] [varchar](max) NULL,
	[AdImage] [image] NULL,
	[Category] [varchar](50) NULL,
	[Client] [varchar](50) NULL,
	[Worker] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[ClosingDate] [date] NULL,
	[OpenDate] [date] NULL,
 CONSTRAINT [PK_AdTable] PRIMARY KEY CLUSTERED 
(
	[PostAdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

ALTER TABLE [dbo].[AdTable]  WITH CHECK ADD  CONSTRAINT [FK_AdTables_Clients] FOREIGN KEY([Client])
REFERENCES [dbo].[Clients] ([Username])
GO

ALTER TABLE [dbo].[AdTable] CHECK CONSTRAINT [FK_AdTables_Clients]
GO

CREATE TABLE [dbo].[Ratings](
	[Worker] [varchar](50) NOT NULL,
	[JobID] [int] NOT NULL,
	[TimeManagement] [int] NULL,
	[Interpersonal] [int] NULL,
	[Quality] [int] NULL,
	[Profesionalism] [int] NULL,
	[Consistency] [int] NULL,
	[QuickRating] [int] NULL CONSTRAINT [DF_Ratings_QuickRating]  DEFAULT ((0)),
	[jobAverage] [int] NULL,
	[Comments] [varchar](max) NULL,
	[Pending] [varchar](50) NULL,
 CONSTRAINT [PK_Ratings_1] PRIMARY KEY CLUSTERED 
(
	[Worker] ASC,
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]


ALTER TABLE [dbo].[Ratings]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_AdTable] FOREIGN KEY([JobID])
REFERENCES [dbo].[AdTable] ([PostAdId])
GO

ALTER TABLE [dbo].[Ratings] CHECK CONSTRAINT [FK_Ratings_AdTable]
GO

ALTER TABLE [dbo].[Ratings]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_Workers] FOREIGN KEY([Worker])
REFERENCES [dbo].[Workers] ([Username])
GO

ALTER TABLE [dbo].[Ratings] CHECK CONSTRAINT [FK_Ratings_Workers]
GO

CREATE TABLE [dbo].[Responses](
	[AdID] [int] NULL,
	[Worker] [varchar](50) NULL,
	[Comment] [varchar](max) NULL,
	[Checked] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

ALTER TABLE [dbo].[Responses]  WITH CHECK ADD  CONSTRAINT [FK_Responses_Workers] FOREIGN KEY([Worker])
REFERENCES [dbo].[Workers] ([Username])
GO

ALTER TABLE [dbo].[Responses] CHECK CONSTRAINT [FK_Responses_Workers]
GO



CREATE TABLE [dbo].[Messenges](
	[PostAdId] [int] NOT NULL,
	[Messenge] [varchar](50) NULL,
	[Sender] [varchar](50) NULL,
	[Date] [date] NULL
) ON [PRIMARY]

ALTER TABLE [dbo].[Messenges]  WITH CHECK ADD  CONSTRAINT [FK_Messenges_AdTable] FOREIGN KEY([PostAdId])
REFERENCES [dbo].[AdTable] ([PostAdId])


CREATE TABLE [dbo].[AverageWorkerRating](
	[Worker] [varchar](50) NOT NULL,
	[AverageRating] [int] NULL,
 CONSTRAINT [PK_AverageWorkerRating] PRIMARY KEY CLUSTERED 
(
	[Worker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE [dbo].[AverageWorkerRating]  WITH CHECK ADD  CONSTRAINT [FK_AverageWorkerRating_Workers] FOREIGN KEY([Worker])
REFERENCES [dbo].[Workers] ([Username])
GO

ALTER TABLE [dbo].[AverageWorkerRating] CHECK CONSTRAINT [FK_AverageWorkerRating_Workers]
GO

CREATE TABLE [dbo].[ClientRating](
	[Client] [varchar](50) NOT NULL,
	[JobID] [int] NOT NULL,
	[Rating] [int] NULL,
	[Comment] [varchar](max) NULL,
 CONSTRAINT [PK_ClientRating] PRIMARY KEY CLUSTERED 
(
	[Client] ASC,
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

ALTER TABLE [dbo].[ClientRating]  WITH CHECK ADD  CONSTRAINT [FK_ClientRating_AdTable] FOREIGN KEY([JobID])
REFERENCES [dbo].[AdTable] ([PostAdId])
GO

ALTER TABLE [dbo].[ClientRating] CHECK CONSTRAINT [FK_ClientRating_AdTable]
GO

ALTER TABLE [dbo].[ClientRating]  WITH CHECK ADD  CONSTRAINT [FK_ClientRating_Clients] FOREIGN KEY([Client])
REFERENCES [dbo].[Clients] ([Username])
GO

ALTER TABLE [dbo].[ClientRating] CHECK CONSTRAINT [FK_ClientRating_Clients]
GO


CREATE TABLE [dbo].[AverageClientRating](
	[Client] [varchar](50) NOT NULL,
	[AverageRating] [int] NULL,
 CONSTRAINT [PK_AverageClientRating] PRIMARY KEY CLUSTERED 
(
	[Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
ALTER TABLE [dbo].[AverageClientRating]  WITH CHECK ADD  CONSTRAINT [FK_AverageClientRating_Clients] FOREIGN KEY([Client])
REFERENCES [dbo].[Clients] ([Username])
GO

ALTER TABLE [dbo].[AverageClientRating] CHECK CONSTRAINT [FK_AverageClientRating_Clients]
GO






CREATE TABLE [dbo].[Administrators](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Administrators] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[AdminStats](
	[Type] [varchar](50) NOT NULL,
	[Category] [varchar](50) NULL,
	[JoinDate] [date] NULL
) ON [PRIMARY]
