Parancsok:
CREATE DATABASE kutyamenhely;

CREATE TABLE adatok (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nev VARCHAR(20) NOT NULL,
    kor INT CHECK (kor < 30),
    nem VARCHAR(20) DEFAULT "kan",
    megjegyzes VARCHAR(500)
);

INSERT INTO adatok (id, nev, kor, nem, megjegyzes)
VALUES(1, "Smebilülák", "10", "hím", "abababaabababababababababbaabbabbabaaaba");

INSERT INTO adatok (id, nev, kor, nem, megjegyzes)
VALUES(2, "Franc", "16", "nőstény", "bebebebebebbebbebebebebebeebebebebe");

INSERT INTO adatok (id, nev, kor, nem, megjegyzes)
VALUES(3, "Öcsisajt", "5", "hím", "cicicicicicicicicicicicicicicicicicicicicicicici");