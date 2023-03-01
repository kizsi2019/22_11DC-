import mysql.connector
import json
mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    database="mozi"
)
mycursor = mydb.cursor()
mycursor.execute('''Select * 
from filmek
where mufaj = "vígjáték"''')
myresult = mycursor.fetchall()
for x in myresult:
    print(x)