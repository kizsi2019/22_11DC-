1.
 SELECT state_province FROM Customers
  UNION
  SELECT ship_state_province FROM Orders
  ORDER BY City;
2
  SELECT COUNT(ProductID), 	ProductName
  FROM products
  GROUP BY categoryid
  ORDER BY COUNT(ProductID) DESC;
3
unavaible in the online catalogue

4
  SELECT COUNT(CustomerID), City
  FROM Customers
  GROUP BY City
  HAVING COUNT(CustomerID) > 3
  ORDER BY COUNT(CustomerID) DESC;
