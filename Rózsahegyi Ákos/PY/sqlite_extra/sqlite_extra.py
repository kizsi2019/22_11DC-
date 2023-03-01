import sqlite3

con = sqlite3.connect("tutorial.db")
cur = con.cursor()

cur.execute('''
    CREATE TABLE szgk(
            id INT, 
            tipus VARCHAR(20), 
            modell VARCHAR(20), 
            rendszam VARCHAR(15), 
            ajtok_szama INT,
            gyartas_eve DATE
        );
''')
cur.execute('''
    INSERT INTO szgk (id, tipus, modell, rendszam, ajtok_szama, gyartas_eve)
    VALUES(10, 'Opel', 'Corsa C', 'AAA123', 4, '2002-10-03'); 
''')
con.commit()

for row in cur.execute("SELECT * FROM szgk"):
    print(row)

con.close()