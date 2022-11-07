USE club;

SELECT ujsagirok.nev, sportolok.nev, ujsagirok.sportag
FROM ujsagirok
INNER JOIN sportolok
ON ujsagirok.sportag = sportolok.sportag;






USE sakk;

SELECT class_10.name, class_11.name
FROM class_10
CROSS JOIN class_11;






USE sakk;

SELECT A.name AS player_A, B.name AS player_B, A.city
FROM students A, students B
WHERE A.id <> B.id
AND A.city = B.city
ORDER BY A.city;