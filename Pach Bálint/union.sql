1)
Select ship_state_province FROM orders UNION ALL SELECT state_province FROM Costumers;
2)
SELECT COUNT(id), category FROM products GROUP BY Category;
3)
SELECT COUNT(id) ship_city FROM orders GROUP BY ship_city;
4)
SELECT COUNT(id) city FROM Customers GROUP BY city HAVE COUNT(id) > 3;
