import mysql.connector
mydb = mysql.connector.connect(
  host="localhost",
  user="root",
    database="formula1"
)
mycursor = mydb.cursor()
mycursor.execute('''select vezeteknev, rajtszam, csapatnev, 2019-year(szuletesidatum) as eletkor
from pilotak
order by eletkor desc''')
myresult = mycursor.fetchall()
for x in myresult:
    print(x)