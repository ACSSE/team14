CREATE TABLE [dbo].[Workers](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[MobileNumber] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
	[Description] [varchar](max) NULL,
	[Region] [varchar](50) NULL,
 CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
