DROP TABLE IF EXISTS szgk;
CREATE TABLE szgk(
      id INT PRIMARY KEY AUTO_INCREMENT, 
      tipus VARCHAR(20) DEFAULT 'Toyota', 
      modell VARCHAR(20) NOT NULL, 
      rendszam VARCHAR(15) UNIQUE, 
      ajtok_szama INT CHECK (ajtok_szama < 6),
      gyartas_eve DATE
);
DROP TABLE IF EXISTS tulajdonos;
CREATE TABLE tulajdonos(
      id INT ,
      név VARCHAR(20),
      FOREIGN KEY (id) REFERENCES szgk (id)
);

INSERT INTO szgk (id, tipus, modell, rendszam, ajtok_szama, gyartas_eve)
  VALUES(10, 'Opel', 'Corsa C', 'AAA123', 4, '2002-10-03'); 
INSERT INTO tulajdonos (id, név)
  VALUES(10, 'János');