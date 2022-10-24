1:
CREATE DATABASE muhely;
USE muhely;
  
DROP TABLE IF EXISTS szgk;
  
CREATE TABLE szgk(
    id INT PRIMARY KEY AUTO_INCREMENT, 
    type VARCHAR(20), 
    modell VARCHAR(20), 
    platenumber VARCHAR(15), 
    doorcount INT,
    manu_date DATE
);
  
INSERT INTO szgk (type, modell, platenumber, doorcount, manu_date) VALUES("Ford", "GT", "XENON54", 4, "2018-05-07");
INSERT INTO szgk (type, modell, platenumber, doorcount, manu_date) VALUES("Ferrari", "458", "TITAN22", 4, "2014-02-01");

CREATE TABLE car_owners (
    owner_id INT,
    id INT,
    PRIMARY KEY (owner_id),
    owner_name VARCHAR(30),
    owner_age INT,
    address VARCHAR(30),
    FOREIGN KEY (id) REFERENCES szgk (id)
);

INSERT INTO car_owners (owner_id, id, owner_name, owner_age, address)
VALUES(10, 1, "Lajos Olajos", 27, "Bucharest");
INSERT INTO car_owners (owner_id, id, owner_name, owner_age, address)
VALUES(20, 2, "Nagy Zsigmond", 41, "Munchen");


2:
CREATE DATABASE kutyamenhely;
USE kutyamenhely;
  
DROP TABLE IF EXISTS dogz;
  
CREATE TABLE dogz (
    id INT PRIMARY KEY AUTO_INCREMENT,
    dogname VARCHAR(20) NOT NULL,
    dogage INT CHECK (dogage < 30),
    dogsex VARCHAR(10) DEFAULT "kan",
    comment VARCHAR(500)
);

INSERT INTO dogz (dogname, dogage, dogsex, comment) VALUES(Rexy", 7, "male", "Doesn't like heights");
INSERT INTO dogz (dogname, dogage, dogsex, comment) VALUES("Berry", 9, "female", "Loves her toy");

CREATE TABLE dog_ownerz (
    dogowner_id INT,
    id INT,
    PRIMARY KEY (dogowner_id),
    dogowner_name VARCHAR(30),
    dogowner_age INT,
    address VARCHAR(30),
    FOREIGN KEY (id) REFERENCES dogz (id)
);

INSERT INTO dog_ownerz (dogowner_id, dogowner_name, dogowner_age, address) VALUES(12, "Billy Gates", 33, "Szeged");
INSERT INTO dog_ownerz (dogowner_id, dogowner_name, dogowner_age, address) VALUES(18, "Beach Rachel", 37, "Budapest");