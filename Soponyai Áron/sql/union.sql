
SELECT ship_state_province 
FROM orders 
UNION ALL 
SELECT state_province 
FROM customers;




SELECT COUNT(id), category 
FROM products 
GROUP BY category;




SELECT COUNT(id) ship_city 
FROM orders 
GROUP BY ship_city;




SELECT COUNT(id), city 
FROM Customers 
GROUP BY city 
HAVING COUNT(id) > 3;