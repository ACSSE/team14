CREATE TABLE [dbo].[AdTable] (
    [PostAdId]      INT          IDENTITY (1, 1) NOT NULL,
    [AdTitle]       VARCHAR (50) NULL,
    [AdDescription] VARCHAR (50) NULL,
    [AdImage]       IMAGE        NULL,
    [Category]      VARCHAR (50) NULL,
    [Client]        VARCHAR (50) NULL,
    [Worker]        VARCHAR (50) NULL,
    [Status]        VARCHAR (50) NULL,
    [OpenDate]      DATE         NULL,
    [PersonalAd]    VARCHAR (50) NULL,
    CONSTRAINT [PK_AdTable] PRIMARY KEY CLUSTERED ([PostAdId] ASC),
    CONSTRAINT [FK_AdTable_ToTable] FOREIGN KEY ([PersonalAd]) REFERENCES [dbo].[Workers] ([Username])
);

