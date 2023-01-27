-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 8. feladat:
 CREATE DATABASE konyvtarak
 DEFAULT CHRACTER SET utf8
 COLLATE utf8_hungarian_ci; 

-- 10. feladat:

 UPDATE
 megyek
 SET
 megyeNev="Budapest"
 WHERE
 megyeNev="BP";

Szakkönyvtárak száma (
-- 11. feladat:
 SELECT
 konyvtarNev,
 irsz
 FROM
 konyvtarak
 WHERE
 konyvtarNev LIKE "%Szakkönyvtár%"; 

-- 12. feladat:
 SELECT konyvtarNev, irsz, cím FROM konyvtarak WHERE
irsz LIKE "1%" ORDER BY irsz ASC; 

-- 13. feladat:
SELECT
 telepNev,
 COUNT(id) AS konyvtarDarab
 FROM
 konyvtarak INNER JOIN telepulesek
 ON konyvtarak.irsz=telepulesek.irsz
 GROUP BY
 telepNev
 HAVING
 konyvtarDarab >=7; 

-- 14. feladat:
SELECT
 megyeNev,
 COUNT(irsz) AS telepulesDarab
 FROM
 telepulesek INNER JOIN megyek
 ON telepulesek.megyeId=megyek.id
 WHERE
 irsz NOT LIKE "1%"
 GROUP BY
 megyeNev
 ORDER BY
 telepulesDarab DESC; 

