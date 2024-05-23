CREATE DATABASE abart
    DEFAULT CHARACTER SET = 'utf8mb4';

use abart;
    CREATE TABLE users (
        id INT AUTO_INCREMENT PRIMARY KEY,
        username VARCHAR(50) NOT NULL,
        password VARCHAR(255) NOT NULL, -- hashed password
        email VARCHAR(255) UNIQUE NOT NULL
    );

    CREATE TABLE inventory (
        id INT AUTO_INCREMENT PRIMARY KEY,
        item_name VARCHAR(100) NOT NULL,
        quantity INT NOT NULL,
        price DECIMAL(10, 2) NOT NULL
    );

    CREATE TABLE transactions (
        id INT AUTO_INCREMENT PRIMARY KEY,
        user_id INT,
        transaction_date DATETIME DEFAULT CURRENT_TIMESTAMP,
        total DECIMAL(10, 2),
        FOREIGN KEY (user_id) REFERENCES users(id)
    );

    CREATE TABLE transaction_items (
        transaction_id INT,
        inventory_id INT,
        quantity INT NOT NULL,
        FOREIGN KEY (transaction_id) REFERENCES transactions(id),
        FOREIGN KEY (inventory_id) REFERENCES inventory(id)
    );