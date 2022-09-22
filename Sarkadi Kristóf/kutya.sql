DROP DATABASE IF EXISTS kutyamenhely
CREATE DATABASE kutyamenhely;
USE kutyahely;
  
DROP TABLE IF EXISTS szgk;
  
CREATE TABLE szgk(
    id INT, 
    nev VARCHAR(20), 
    kor INT(20), 
    nem VARCHAR(15), 
    megjedzes VARCHAR(500)
);








INSERT INTO szgk (id, nev, kor, nem, megjedzes)
VALUES(1, 'Kutya', '5', 'kan', 'aaaaaaaaaaaaa');