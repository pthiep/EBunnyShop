CREATE TABLE [dbo].[Error]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Message] NVARCHAR(MAX) NULL, 
    [StackTrace] NVARCHAR(MAX) NULL, 
    [CreatedDate] DATETIME NULL
)
