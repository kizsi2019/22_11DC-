import mysql.connector

mydb = mysql.connector.connect(
    host = "localhost",
    user = "root",
    database = "formula1_11d"
)
mycursor = mydb.cursor()
mycursor.execute('''SELECT vezeteknev, rajtszam, csapatnev, 2019-year(szuletesidatum) as eletkor FROM pilotak''')
myresult = mycursor.fetchall()
for x in myresult:
    print(x)