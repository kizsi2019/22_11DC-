import mysql.connector

mydb = mysql.connector.connect(
  host="localhost",
  user="root",
    database="formula1"
)

mycursor = mydb.cursor()
mycursor.execute("SELECT * FROM eredmenyek")
myresult = mycursor.fetchall()
for x in myresult:
    print(x)
