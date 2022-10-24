1

 SELECT 'Orders' AS Type, ship_state_province
  FROM Orders
  UNION
  SELECT 'Orders', state_province
  FROM Customers;

2

SELECT COUNT (id) FROM products

3




4

SELECT COUNT(id), city
FROM customers 
GROUP BY city HAVING COUNT(id) > 3