CREATE TABLE x1_customers SELECT (id) AS customers, city as city FROM customers GROUP BY city;

CREATE TABLE x2_products
SELECT COUNT (id) AS termekek_szama, category
FROM products
GROUP BY category;