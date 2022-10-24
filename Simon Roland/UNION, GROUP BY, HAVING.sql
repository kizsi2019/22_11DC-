1. feladat
SELECT ship_state_province FROM orders 
UNION 
SELECT state_province FROM customers;

Az orders tábla ship_state_province mezőjének értékeit fésüld össze a customers tábla state_province mezőjének értékeivel úgy, hogy
- minden érték csak egyszer szerepeljen,
- az értékek ismétlődhetnek!



2. feladat
SELECT COUNT(`categoryId`) 
FROM product;

3. feladat

SELECT COUNT(`ship_city`) 
FROM orders 
GROUP BY `ship_city`;

4. Feladat
SELECT COUNT(id), city 
FROM Customers 
GROUP BY city 
HAVING COUNT(id) > 3;

