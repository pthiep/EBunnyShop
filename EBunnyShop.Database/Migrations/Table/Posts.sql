CREATE TABLE [dbo].[Posts]
(
	[ID] INT NOT NULL,
	[Name] NVARCHAR(250) NOT null,
	[Alias] NVARCHAR(250) NOT null,
    [CategoryID] INT NULL,
    [Image] NVARCHAR(500) NULL,
	[Description] NVARCHAR(500) NULL,
	[Content] NVARCHAR(MAX) NULL,
    [MetaKeyword] NVARCHAR(250) NULL, 
    [MetaDescription] NVARCHAR(250) NULL, 
    [CreatedDate] DATE NULL, 
    [CreatedBy] VARCHAR(50) NULL, 
    [UpdatedDate] DATE NULL, 
    [UpdatedBy] VARCHAR(50) NULL, 
    [Status] BIT NOT NULL, 
    [HomeFlag] BIT NULL, 
    [HotFlag] BIT NULL, 
	[ViewCount] INT NULL, 
    CONSTRAINT [PK_Posts] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Posts_PostCategories] FOREIGN KEY ([CategoryID]) REFERENCES [PostCategories]([ID])
)
