CREATE TABLE Product (ProductID INT, ProductName VARCHAR(100)) CREATE TABLE ProductDescription (ProductID INT, ProductDescription VARCHAR(800)) -- 
-- add initial data :
INSERT INTO
    Product
VALUES
    (680, 'HL Road Frame - Black, 58'),
    (706, 'HL Road Frame - Red, 58'),
    (707, 'Sport-100 Helmet, Red')
INSERT INTO
    ProductDescription
VALUES
    (
        680,
        'Replacement mountain wheel for entry-level rider.'
    ),
    (
        706,
        'Sturdy alloy features a quick-release hub.'
    ),
    (
        707,
        'Aerodynamic rims for smooth riding.'
    )