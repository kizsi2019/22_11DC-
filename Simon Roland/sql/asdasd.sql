CREATE TABLE x1_customers
SELECT COUNT(id) AS customers, city AS city
FROM customers
GROUP BY city



CREATE TABLE x2_products
SELECT COUNT(id) AS termek_szama, category
FROM products
GROUP BY category;