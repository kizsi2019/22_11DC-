from flask import Flask

app = Flask(__name__)

@app.route("/")
@app.route("/home")
def home():
    return "Üdv a Sulipy üzenőfalán!"

@app.route("/contact")
def contact():
    return f"Jelentkezés a kurzusokra: info@sulipy.hu"

if __name__ == "__main__":
    app.run(debug=True)