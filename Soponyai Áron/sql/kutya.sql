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
  VALUES('roben', '30', kan, 'csontos és döglődik'); 

INSERT INTO KUTYA (nev, kor, nem, megjegyzes)
  VALUES('rooli', '11', kan, 'nem jó nem muksit'); 