SELECT SupplierName, Country FROM Suppliers
WHERE Country = "USA" OR Country = "UK"

SELECT SupplierName, Country FROM Suppliers
WHERE Country = "USA" OR Country = "Boston" OR Country = "New Orleans"


SELECT ProductName, Price FROM Products
ORDER BY Price;

SELECT CategoryName, Description FROM Categories
WHERE CategoryName = "Produce"