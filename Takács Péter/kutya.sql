DROP DATABASE IF EXISTS kutyamenhely;
CREATE DATABASE kutyamenhely;
USE kutyamenhely;
DROP TABLE IF EXISTS KUTYA;

CREATE TABLE KUTYA(
      id INT PRIMARY KEY AUTO_INCREMENT, 
      nev varchar(30) NOT NULL,
      kor int check (kor < 30), 
      nem VARCHAR(20) DEFAULT 'kan',
      megjegyzes VARCHAR(20)
  );

INSERT INTO KUTYA (nev, kor, nem, megjegyzes)
  VALUES('hópehely', '1', kan, 'mókás'); 

INSERT INTO KUTYA (nev, kor, nem, megjegyzes)
  VALUES('szkoobi', '8', kan, 'hangos nagyon hangos'); 