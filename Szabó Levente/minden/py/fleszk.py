from flask import Flask, redirect, url_for
from datetime import datetime

app = Flask(__name__)

@app.route("/")
@app.route("/home")
def home():
    return 'Szia'

@app.route("/message board")
def message_board():
    return redirect(url_for('home'))

@app.route("/contract")
def contract():
    return 'jelenkezz'
@app.route("/time")
def time():
    nao = datetime.now()
    current_time = nao.strftime("%H:%M:%S")
    return 'Pontos idő' + current_time

@app.route("/course/(int:number>")
def course(number):
    return f"Ez a {number} jó"


if __name__ == '__main__':
    app.run(debug=True)