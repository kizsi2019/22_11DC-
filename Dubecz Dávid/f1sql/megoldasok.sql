-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1:
CREATE DATABASE formula1_11D
CHARSET utf8
COLLATE utf8_hungarian_ci;

-- 3:
UPDATE nagydijak
SET korokszama = 70
WHERE nev = "Hungarian Grand Prix";

-- 4:
SELECT vezeteknev, rajtszam, csapatnev, 2019 - YEAR(szuletesidatum) AS eletkor
FROM pilotak
ORDER BY eletkor DESC;

-- 5:
SELECT nev, vezeteknev, keresztnev, versenynap
FROM pilotak, eredmenyek, nagydijak
WHERE pilotak.id = eredmenyek.pilotaid AND eredmenyek.nagydijid = nagydijak.id
AND helyezes = 1
ORDER BY versenynap ASC;

-- 6:
SELECT CONCAT(keresztnev, ' ', vezeteknev) AS nev, csapatnev, SUM(pontszam) AS osszpontszam
FROM pilotak, eredmenyek, nagydijak
WHERE pilotak.id = eredmenyek.pilotaid AND eredmenyek.nagydijid = nagydijak.id
GROUP BY vezeteknev, keresztnev, csapatnev
ORDER BY osszpontszam DESC
LIMIT 3;
