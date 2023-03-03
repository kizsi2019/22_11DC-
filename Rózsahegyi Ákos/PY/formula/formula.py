import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  database="formula1"
)

mycursor = mydb.cursor()
'''
mycursor.execute("SELECT * FROM pilotak")
'''
mycursor.execute('''SELECT vezeteknev, rajtszam, csapatnev, 2019 - YEAR(szuletesidatum) AS eletkor
FROM pilotak
ORDER BY eletkor DESC;''')

myresult = mycursor.fetchall()

for x in myresult:
  print(x)