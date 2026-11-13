CREATE TABLE dbo.Sales
(
SaleID BIGINT IDENTITY(1,1) PRIMARY KEY,
SaleDate DATETIME2 NOT NULL DEFAULT GETDATE(),
Subtotal DECIMAL(19,2) NOT NULL,
TotalAmount DECIMAL(19,2) NOT NULL,
PaymentMethod NVARCHAR(20) NOT NULL,


CONSTRAINT CK_Sales_PaymentMethod
    CHECK (PaymentMethod IN ('Cash', 'Card', 'Other')),

CONSTRAINT CK_Sales_Amounts
    CHECK (Subtotal >= 0 AND TotalAmount >= 0)


);
