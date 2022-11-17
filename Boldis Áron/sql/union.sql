1. feladat
SELECT ship_state_province FROM orders UNION ALL SELECT state_province FROM customers;
2. feladat
SELECT COUNT(id), category FROM products GROUP BY category;
3.
SELECT COUNT(id) ship_city FROM orders GROUP BY ship_city;
4.
SELECT COUNT(id), city FROM Customers GROUP BY city HAVING COUNT(id) > 3;