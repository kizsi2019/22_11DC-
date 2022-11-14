DROP DATABASE IF EXISTS muhely;
  CREATE DATABASE muhely;
  USE muhely;

DROP TABLE IF EXISTS tulajdonos;

	CREATE TABLE tulajdonos (
      személy_id INT,
      name VARCHAR(40),
      PRIMARY KEY (személy_id)
  );
  
DROP TABLE IF EXISTS szgk;
  
  CREATE TABLE szgk(
      id INT, 
      tipus VARCHAR(20), 
      modell VARCHAR(20), 
      rendszam VARCHAR(15), 
      ajtok_szama INT,
      gyartas_eve DATE,
      tulajdonos_id INT,
      PRIMARY KEY (tulajdonos_id),
      CONSTRAINT FK_tulajdonos_szgk 
      FOREIGN KEY (tulajdonos_id) REFERENCES tulajdonos (személy_id)
  );
INSERT INTO tulajdonos (személy_id, name) VALUES (154, "Páspa György");

INSERT INTO szgk (id, tipus, modell, rendszam, ajtok_szama, gyartas_eve, tulajdonos_id)
  VALUES(10, 'Opel', 'Corsa C', 'AAA123', 4, '2002-10-03', 154);
