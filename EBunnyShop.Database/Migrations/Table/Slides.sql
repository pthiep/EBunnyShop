CREATE TABLE [dbo].[Slides]
(
	[ID] INT NOT NULL,
	[Name] VARCHAR NOT NULL,
	[Description] NVARCHAR(250) NULL,
	[Image] NVARCHAR(500) NOT NULL,
	[Url] NVARCHAR(500) NULL,
	[DislayOrder] INT,
	[Status] BIT NOT NULL, 
    CONSTRAINT [PK_Slides] PRIMARY KEY ([ID])
)
