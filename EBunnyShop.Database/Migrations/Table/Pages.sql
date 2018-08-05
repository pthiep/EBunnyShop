CREATE TABLE [dbo].[Pages]
(
	[ID] INT NOT NULL, 
    [Name] NVARCHAR(250) NULL, 
    [Content] VARCHAR(MAX) NULL,
	[MetaKeyword] NVARCHAR(250) NULL, 
    [MetaDescription] NVARCHAR(250) NULL, 
	[Status] BIT NOT NULL, 
    CONSTRAINT [PK_Pages] PRIMARY KEY ([ID])
)
