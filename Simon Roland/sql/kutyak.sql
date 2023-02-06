CREATE DATABASE kutyamenhely
USE kutyamenhely  





CREATE TABLE kutyak(
id INT PRIMARY KEY AUTO_INCREMENT, 
nev VARCHAR(30) NOT NULL, 
kor INT CHECK (kor < 30), 
nem VARCHAR (30)DEFAULT 'Kan', 
megjegyzes VARCHAR (500)
);

INSERT INTO kutyak (nev, nem, megjegyzes)
VALUES('Arnold', '12', 'Barátságos, szerelmetes kutyus várja szerető családját'); 