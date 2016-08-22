<<<<<<< HEAD
﻿CREATE TABLE [dbo].[LoginClient] (
    [Name]         NVARCHAR (50) NULL,
    [SurName]      NVARCHAR (50) NULL,
    [UserName]     NVARCHAR (50) NOT NULL,
    [Password]     NVARCHAR (50) NULL,
    [Address]      NVARCHAR (50) NULL,
    [MobileNumber] NVARCHAR (50) NULL,
    [Email]        NVARCHAR (50) NULL,
    [PostAdId]     INT           NOT NULL IDENTITY(0, 1),
    PRIMARY KEY CLUSTERED ([UserName] ASC),
    CONSTRAINT [FK_LoginClient_PostAdClient] FOREIGN KEY ([PostAdId]) REFERENCES [dbo].[PostAdClient] ([PostAdId])
);

=======
﻿CREATE TABLE [dbo].[LoginClient] (
    [Name]         NVARCHAR (50) NULL,
    [SurName]      NVARCHAR (50) NULL,
    [UserName]     NVARCHAR (50) NOT NULL,
    [Password]     NVARCHAR (50) NULL,
    [Address]      NVARCHAR (50) NULL,
    [MobileNumber] NVARCHAR (50) NULL,
    [Email]        NVARCHAR (50) NULL,
    [PostAdId]     INT           NOT NULL IDENTITY(0, 1),
    PRIMARY KEY CLUSTERED ([UserName] ASC),
    CONSTRAINT [FK_LoginClient_PostAdClient] FOREIGN KEY ([PostAdId]) REFERENCES [dbo].[PostAdClient] ([PostAdId])
);

>>>>>>> 3924db60ce15290221df9b838aeba9dff3fe785d
