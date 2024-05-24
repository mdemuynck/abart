from flask import Flask, jsonify
from flask_cors import CORS
from flask_sqlalchemy import SQLAlchemy

app = Flask(__name__)
CORS(app)
app.config['SQLALCHEMY_DATABASE_URI'] = 'mysql://baragent:7FNwpGmU@localhost/abart'
db = SQLAlchemy(app)

class Inventory(db.Model):
    id = db.Column(db.Integer, primary_key=True)
    item_name = db.Column(db.String(50), nullable=False)
    quantity = db.Column(db.Integer, nullable=False)

    def to_dict(self):
        return {
            'id': self.id,
            'item_name': self.item_name,
            'quantity': self.quantity
        }

@app.route('/')
def hello_world():
    return 'Hello, World!'

@app.route('/inventory', methods=['GET'])
def get_inventory():
    inventory = Inventory.query.all()
    return jsonify([item.to_dict() for item in inventory])

if __name__ == '__main__':
    app.run(debug=True)
    