CREATE TABLE [dbo].[Menus]
(
	[ID] INT NOT NULL,
	[Name] NVARCHAR(500) NOT NULL,
	[Url] NVARCHAR(500) NOT NULL,
	[DislayOrder] INT,
	[GroupID] INT,
	[Taget] VARCHAR(10),
	[Status] BIT, 
    CONSTRAINT [PK_Menus] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_Menus_MenuGroups] FOREIGN KEY ([ID]) REFERENCES [MenuGroups]([ID])
)
