CREATE TABLE [dbo].[VisitorStatistics]
(
	[ID] UNIQUEIDENTIFIER NOT NULL,
	[VisitedDate] DATETIME NOT NULL, 
    [IP Address] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_VisitorStatistics] PRIMARY KEY ([ID])
)
