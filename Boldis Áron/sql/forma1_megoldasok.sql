-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
drop database if exists
CREATE DATABASE formula112d
DEFAULT charset = utf8
COLLATE utf8_hungarian_ci;

-- 3. feladat:
UPDATE nagydijak 
SET korokszama = 70 
WHERE id = 12;

-- 4. feladat:
SELECT vezeteknev, rajtszam, csapatnev, 2019 - year(szuletesidatum) AS eletkor 
FROM pilotak;

-- 5. feladat:


-- 6. feladat:

