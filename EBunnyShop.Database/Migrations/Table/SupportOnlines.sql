CREATE TABLE [dbo].[SupportOnline]
(
	[ID] INT NOT NULL, 
    [Name] NVARCHAR(50) NULL,
	[Department] NVARCHAR(250) NULL,
    [Skype] NVARCHAR(250) NULL, 
    [Email] NVARCHAR(250) NULL, 
    [Status] BIT NOT NULL, 
    CONSTRAINT [PK_SupportOnline] PRIMARY KEY ([ID])
)
