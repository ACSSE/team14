CREATE TABLE [dbo].[Ratings](
	[Worker] [varchar](50) NOT NULL,
	[JobID] [int] NOT NULL,
	[TimeManagement] [int] NULL,
	[Interpersonal] [int] NULL,
	[Quality] [int] NULL,
	[Profesionalism] [int] NULL,
	[QuickRating] [int] NULL,
	[Consistency] [int] NULL,
	[Comments] [varchar](max) NULL,
	[Pending] [varchar](50) NULL,
 CONSTRAINT [PK_Ratings_1] PRIMARY KEY CLUSTERED 
(
	[Worker] ASC,
	[JobID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[AdTable](
	[PostAdId] [int] IDENTITY(1,1) NOT NULL,
	[AdTitle] [varchar](50) NULL,
	[AdDescription] [varchar](50) NULL,
	[AdImage] [image] NULL,
	[Category] [varchar](50) NULL,
	[Client] [varchar](50) NULL,
	[Worker] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_AdTable] PRIMARY KEY CLUSTERED 
(
	[PostAdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[AverageClientRating](
	[Client] [varchar](50) NOT NULL,
	[AverageRating] [int] NULL,
 CONSTRAINT [PK_AverageClientRating] PRIMARY KEY CLUSTERED 
(
	[Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[AverageWorkerRating](
	[Worker] [varchar](50) NOT NULL,
	[AverageRating] [int] NULL,
 CONSTRAINT [PK_AverageWorkerRating] PRIMARY KEY CLUSTERED 
(
	[Worker] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


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


CREATE TABLE [dbo].[Messenges](
	[PostAdId] [int] NOT NULL,
	[Messenge] [varchar](50) NULL,
	[Sender] [varchar](50) NULL,
	[Date] [date] NULL
) ON [PRIMARY]


CREATE TABLE [dbo].[Responses](
	[AdID] [int] NULL,
	[Worker] [varchar](50) NULL,
	[Comment] [varchar](max) NULL,
	[Checked] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]