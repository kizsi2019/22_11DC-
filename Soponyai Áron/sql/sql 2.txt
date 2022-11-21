SELECT SupplierName, country FROM [Suppliers] where country = "USA" or country = "UK" 
SELECT SupplierName, city, country FROM [Suppliers] where country = "USA" and city = "New Orleans" or city = "Boston"
SELECT SupplierName, country FROM [Suppliers] where not country = "Japan" or not country = "Canada"

SELECT ProductName, Price FROM [Products] order by Price asc
SELECT ProductName, Price FROM [Products] order by Price desc
SELECT ProductName, Unit FROM [Products] order by ProductName asc, unit desc