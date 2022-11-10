CREATE TABLE vasarlok_szama
    SELECT COUNT(id) AS db, city AS város
    FROM customers
    WHERE id > 1
    GROUP BY city; 


  CREATE TABLE prdocts_szama
      SELECT COUNT(id) AS db, category
      FROM products
      GROUP BY category; 