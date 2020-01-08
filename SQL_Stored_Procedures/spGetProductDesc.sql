CREATE PROCEDURE GetProductDesc AS BEGIN
SET
    NOCOUNT ON
SELECT
    P.ProductID,
    P.ProductName,
    PD.ProductDescription
FROM
    Product P
    INNER JOIN ProductDescription PD ON P.ProductID = PD.ProductID
END