from flask import Flask, redirect, url_for, render_template
from datetime import datetime

app = Flask(__name__)

@app.route('/')
@app.route('/home')
def home():
    return render_template('index.html')

@app.route('/message_board')
def message_board():
    return redirect(url_for('home'))

@app.route('/course/<int:number>')
def course(number):
    return f'Ez a {number} kurzus adatlapja.'

@app.route('/contact')
def contact():
    return 'Jelentkezés erre a kurzusra: info@sulipy.hu'

@app.route('/time')
def time():
    now = datetime.now()
    current_time = now.strftime('%H:%M')
    return 'A pontos idő: ' + current_time

if __name__ == '__main__':
    app.run(debug=True)