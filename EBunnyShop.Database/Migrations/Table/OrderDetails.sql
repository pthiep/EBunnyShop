CREATE TABLE [dbo].[OrderDetails]
(
	[OrderID] INT NOT NULL,
	[ProductID] INT NOT NULL,
	[Quantity] INT NOT NULL,
	CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([OrderID], [ProductID]),
    CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY ([OrderID]) REFERENCES [Orders]([ID]), 
    CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY ([ProductID]) REFERENCES [Products]([ID]), 
)
