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