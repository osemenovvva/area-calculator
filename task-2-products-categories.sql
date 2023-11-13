CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255)
);

CREATE TABLE Category (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(255)
);

CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID)
);

INSERT INTO Product VALUES (1, 'TicTac'), (2, 'Snickers'), (3, 'Fanta');
INSERT INTO Category VALUES (1, 'Candy'), (2, 'Chocolate'), (3, 'Cookie');
INSERT INTO ProductCategory VALUES (1, 1), (2, 2), (2, 1);

SELECT p.ProductName "Имя продукта", c.CategoryName "Имя категории"
FROM Product p 
LEFT JOIN ProductCategory pc on p.ProductID = pc.ProductID
LEFT JOIN Category c on pc.CategoryID = c.CategoryID
