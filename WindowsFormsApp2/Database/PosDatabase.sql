CREATE DATABASE POSDatabase;
GO

USE POSDatabase;
GO

CREATE TABLE Products
(
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL DEFAULT 0
);
GO

INSERT INTO Products (ProductName, Category, Price, Stock)
VALUES
('Coca-Cola', 'Drinks', 45.00, 20),
('Pepsi', 'Drinks', 45.00, 15),
('Burger', 'Food', 99.00, 10),
('French Fries', 'Food', 65.00, 25),
('Potato Chips', 'Snacks', 35.00, 30);
