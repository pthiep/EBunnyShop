CREATE TABLE [dbo].[ProductTags]
(
	[ProductID] INT NOT NULL,
	[TagID] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_ProductTags] PRIMARY KEY ([ProductID], [TagID]), 
    CONSTRAINT [FK_ProductTags_Products] FOREIGN KEY ([ProductID]) REFERENCES [Products]([ID]), 
    CONSTRAINT [FK_ProductTags_Tags] FOREIGN KEY ([TagID]) REFERENCES [Tags]([ID]) 
)
