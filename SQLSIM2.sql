CREATE TABLE dbo.SaleItems
(
SaleItemID BIGINT IDENTITY(1,1) PRIMARY KEY,
SaleID BIGINT NOT NULL,
ProductID INT NOT NULL,
Quantity BIGINT NOT NULL,
UnitPrice DECIMAL(19,2) NOT NULL,
Subtotal DECIMAL(19,2) NOT NULL,

CONSTRAINT FK_SaleItems_Sales
    FOREIGN KEY (SaleID)
    REFERENCES dbo.Sales(SaleID),

CONSTRAINT FK_SaleItems_Products
    FOREIGN KEY (ProductID)
    REFERENCES dbo.Products(ProductID),

CONSTRAINT CK_SaleItems_Quantity
    CHECK (Quantity > 0),

CONSTRAINT CK_SaleItems_Prices
    CHECK (UnitPrice >= 0 AND Subtotal >= 0)


);
