import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
  database="mozi"
)

mycursor = mydb.cursor()

mycursor.execute("SELECT * FROM filmek")

myresult = mycursor.fetchall()

for x in myresult:
  print(x)