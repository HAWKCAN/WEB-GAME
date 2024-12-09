from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
def home():
    return render_template("home.html")
@app.route("/action")
def action():
    return render_template("action.html")
@app.route("/puzzle")
def puzzle():
    return render_template("puzzle.html")
@app.route("/sports")
def sports():
    return render_template("sports.html")
@app.route("/report")
def report():
    return render_template("report.html")

if __name__ == "__main__":
    app.run(debug=True)

