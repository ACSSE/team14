CREATE TABLE [dbo].[Responses](
	[AdID] [int] NULL,
	[Worker] [varchar](50) NULL,
	[Comment] [varchar](max) NULL,
	[Checked] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]