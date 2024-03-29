from flask import Flask, redirect, url_for
from datetime import datetime

app = Flask(__name__)

@app.route("/")
@app.route("/home")
def home():
    return "Üdv a Sulipy oldalán!"

@app.route("/contact")
def contact():
    return f"Jelentkezés a kurzusokra: info@sulipy.hu"

@app.route("/time")
def time():
    now = datetime.now()
    current_time = now.strftime("%H:%M:%S")
    return "A pontos idő: " + current_time

@app.route("/uzenofal")
def message_board():
    return redirect(url_for("home"))

@app.route("/course/〈int:number〉")
def course(number):
    return f"Ez a {number}. kurzus adatlapja!"

if __name__ == "__main__":
    app.run(debug=True)