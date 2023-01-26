-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 8. feladat:
CREATE DATABASE konyvtarak DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci

-- 10. feladat:
UPDATE megyek SET megyek.megyeNev="Budapest" WHERE megyek.megyeNev="BP"

-- 11. feladat:
SELECT konyvtarak.konyvtarNev, konyvtarak.irsz FROM konyvtarak WHERE konyvtarak.konyvtarNev LIKE "%Szakkönyvtár%";

-- 12. feladat:
SELECT konyvtarak.konyvtarNev, konyvtarak.irsz, konyvtarak.cim
FROM konyvtarak WHERE konyvtarak.irsz
LIKE "1%" ORDER BY 2 ASC

-- 13. feladat:
SELECT telepulesek.telepNev, COUNT(konyvtarak.id) AS "konyvtarDarab" 
FROM telepulesek, konyvtarak 
WHERE telepulesek.irsz = konyvtarak.irsz 
GROUP BY 1 
HAVING konyvtarDarab >= 7 

-- 14. feladat:
SELECT megyek.megyeNev, COUNT(telepulesek.irsz) AS "telepulesDarab" 
FROM megyek INNER JOIN telepulesek ON telepulesek.megyeId = megyek.id 
WHERE telepulesek.irsz NOT LIKE "1%" 
GROUP BY 1 
ORDER BY 2 DESC;

