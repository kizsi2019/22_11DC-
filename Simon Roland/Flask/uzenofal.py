from flask import Flask

app = Flask(__name__)

@app.route('/')
@app.route('/home')
def home():
    return 'Üdv az oldalon!'


@app.route('/contact')
def contact():
    return 'Jelentkezés erre a kurzusra: info@sulipy.hu'

if __name__ == '__main__':
    app.run(debug=True)