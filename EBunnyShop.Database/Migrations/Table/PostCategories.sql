CREATE TABLE [dbo].[PostCategories]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(250) NOT null,
	[Alias] NVARCHAR(250) NOT null, 
	[Description] NVARCHAR (250) NULL,
    [ParentID] INT NULL, 
    [DislayOrder] INT NULL, 
    [Image] NVARCHAR(500) NULL, 
    [MetaKeyword] NVARCHAR(250) NULL, 
    [MetaDescription] NVARCHAR(250) NULL, 
    [CreatedDate] DATE NULL, 
    [CreatedBy] VARCHAR(50) NULL, 
    [UpdatedDate] DATE NULL, 
    [UpdatedBy] VARCHAR(50) NULL, 
    [Status] BIT NOT NULL, 
    [HomeFlag] BIT NOT NULL, 
    CONSTRAINT [PK_PostCategories] PRIMARY KEY ([ID])
)
