CREATE DATABASE kutyamenhely;
CREATE TABLE kutyak( 
id int PRIMARY KEY AUTO_INCREMENT, 
nev varchar(30) NOT NULL, 
kor INT CHECK (kor < 30), 
nem  varchar(30)DEFAULT "kan", 
megjegyzes varchar(500) 
);

INSERT INTO kutyak (id, nev, kor, nem, megjegyzes)
VALUES (1, "kutya1", 12, "kan", "1. kutya");
INSERT INTO kutyak (id, nev, kor, nem, megjegyzes)
VALUES (2, "kutya2", 12, "kan", "2. kutya");

