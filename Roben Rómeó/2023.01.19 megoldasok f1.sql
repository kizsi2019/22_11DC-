-- A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


-- 1. feladat:
  DROP DATABASE IF EXISTS formula1;
  CREATE DATABASE formula1;
  

-- 3. feladat:
UPDATE nagydijak SET korokszama = 70 WHERE nev = 'Hungarian Grand Prix';

-- 4. feladat:
SELECT vezeteknev, rajtszam, csapatnev, 2019-year(szuletesidatum) AS eletkor FROM pilotak ORDER BY eletkor DESC;

-- 5. feladat:
SELECT nagydijak.nev, pilotak.vezeteknev, pilotak.keresztnev, nagydijak.versenynap FROM eredmenyek JOIN nagydijak ON eredmenyek.nagydijid = nagydijak.id JOIN pilotak ON eredmenyek.pilotaid = pilotak.id WHERE eredmenyek.helyezes = 1 ORDER BY nagydijak.versenynap;

-- 6. feladat:
SELECT CONCAT(pilotak.keresztnev,' ',pilotak.vezeteknev)AS nev, pilotak.csapatnev, SUM(eredmenyek.pontszam)AS osszpontszam FROM eredmenyek JOIN pilotak on eredmenyek.pilotaid = pilotak.id GROUP BY pilotak.vezeteknev, pilotak.keresztnev, pilotak.csapatnev ORDER by osszpontszam DESC LIMIT 3;
