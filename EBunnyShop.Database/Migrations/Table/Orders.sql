CREATE TABLE [dbo].[Orders]
(
	[ID] INT NOT NULL,
	[CustomerName] NVARCHAR(250) NOT NULL,
	[CustomerAddress] NVARCHAR(250) NOT NULL,
	[CustomerEmail] NVARCHAR(250) NOT NULL,
	[CustomerMobile] VARCHAR(50) NOT NULL,
	[CustomerMessage] NVARCHAR(250) NULL, 
	[CreatedDate] DATETIME,
	[CreateBy] VARCHAR(50),
	[PaymentMethod] NVARCHAR(250),
	[PaymentStatus] NVARCHAR(50) NOT NULL,
	[Status] BIT NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([ID])
)
