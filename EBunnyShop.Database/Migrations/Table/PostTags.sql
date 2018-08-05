CREATE TABLE [dbo].[PostTags]
(
	[PostID] INT NOT NULL,
	[TagID] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_PostTags] PRIMARY KEY ([PostID], [TagID]), 
    CONSTRAINT [FK_PostTags_Posts] FOREIGN KEY ([PostID]) REFERENCES [Products]([ID]), 
    CONSTRAINT [FK_PostTags_Tags] FOREIGN KEY ([TagID]) REFERENCES [Tags]([ID]) 
)
