-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
DROP DATABASE IF EXISTS forma1_11d;
CREATE DATABASE forma1_11d;
USE forma1_11d;

-- 3. feladat:
UPDATE nagydijak
set korokszama = '70'
WHERE nev like 'Hungarian%';

-- 4. feladat:
SELECT `szuletesidatum` 
FROM `pilotak` 
ORDER BY '2019' - `szuletesidatum` DESC;

-- 5. feladat:
SELECT vezeteknev, keresztnev, csapatnev
FROM pilotak 
ORDER BY versenynap ASC;

-- 6. feladat:

