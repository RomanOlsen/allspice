CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL PRIMARY KEY COMMENT 'primary key',
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name VARCHAR(255) COMMENT 'User Name',
  email VARCHAR(255) UNIQUE COMMENT 'User Email',
  picture VARCHAR(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

select * from accounts;

CREATE TABLE recipes(
  id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL,
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP NOT NULL,
  title varchar(255) NOT NULL,
  instructions varchar(5000), 
  img varchar(1000) NOT NULL,
  category ENUM('breakfast', 'lunch', 'dinner', 'snack', 'dessert') NOT NULL,
  creator_id VARCHAR(255) not null,
  FOREIGN KEY (creator_id) REFERENCES accounts(id) ON DELETE CASCADE
);


SELECT * FROM recipes

DROP TABLE recipes;
DROP TABLE ingredients;
DROP TABLE favorites;

CREATE TABLE ingredients(
  id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL,
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP NOT NULL,
  name varchar(255) NOT NULL,
  quantity varchar(255) NOT NULL,
  -- recipe_id INT FOREIGN KEY AUTO_INCREMENT NOT NULL -- later on change this to match recipe
  recipe_id int not null,
  FOREIGN KEY (recipe_id) REFERENCES recipes(id) ON DELETE CASCADE
);

select * from ingredients;

CREATE TABLE favorites(
  id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  created_at DATETIME DEFAULT CURRENT_TIMESTAMP NOT NULL,
  updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP NOT NULL,
  recipe_id int not null,
  FOREIGN KEY (recipe_id) REFERENCES recipes(id) ON DELETE CASCADE,
  account_id varchar(255) not null,
  FOREIGN KEY (account_id) REFERENCES accounts(id) ON DELETE CASCADE
);

select * from favorites;

SELECT recipes.*, accounts.* FROM recipes
    INNER JOIN accounts ON accounts.id = recipes.creator_id
