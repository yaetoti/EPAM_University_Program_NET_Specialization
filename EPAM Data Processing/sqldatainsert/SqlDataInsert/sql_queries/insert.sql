INSERT INTO city (name) VALUES
('Kharkiv'),
('Kherson'),
('Kyiv');

-- 5
INSERT INTO street (name, city_id) VALUES
('Heroiv Kharkova', 1),
('Nauky', 1),
('Poltavskyi Shlyakh', 1),
('Antonivska', 2),
('Khreshchatyk', 3);

-- 7
INSERT INTO supermarket (name, street_id, house_number) VALUES
('ATB', 1, '12'),
('Silpo', 2, '24'),
('Furshet', 2, '13'),
('Varus', 3, '46'),
('Auchan', 3, '11'),
('Metro', 4, '23'),
('Velmart', 5, '34');

-- 10
INSERT INTO person (name, surname, birth_date) VALUES
('Ivan', 'Ivanov', '1976-01-01'),
('Petro', 'Petrov', '1965-12-30'),
('Svitlana', 'Svitlanenko', '1987-10-23'),
('Oksana', 'Makarenko', '1984-04-04'),
('Oleksandr', 'Oleksandrenko', '1993-07-05'),
('Pavlo', 'Pavlenko', '2001-06-16'),
('Mykola', 'Mykolenko', '1991-03-17'),
('Vasyl', 'Vasylenko', '1994-08-08'),
('Daria', 'Kovalenko', '1992-05-29'),
('Yehor', 'Koval', '1993-10-10');

-- 2
INSERT INTO contact_type (name) VALUES
('phone'),
('email');

-- 20
INSERT INTO person_contact (person_id, contact_type_id, contact_value) VALUES
(1, 1, '+380501234567'),
(1, 2, 'ivanov@gmail.com'),
(2, 1, '+380509876543'),
(2, 2, 'petrov@gmail.com'),
(3, 1, '+380501234567'),
(3, 2, 'svitlanenko@gmail.com'),
(4, 1, '+380502345678'),
(4, 2, 'makarenko@gmail.com'),
(5, 1, '+380505678901'),
(5, 2, 'oleksandrenko@gmail.com'),
(6, 1, '+380506789012'),
(6, 2, 'pavlenko@gmail.com'),
(7 ,1, '+380507890123'),
(7 ,2, 'mykolenko@gmail.com'),
(8 ,1, '+380508901234'),
(8 ,2, 'vasylenko@gmail.com'),
(9 ,1, '+380509012345'),
(9 ,2, 'kovalenko@gmail.com'),
(10, 1, '+380501234567'),
(10, 2, 'koval@gmail.com');

-- 10
INSERT INTO customer (person_id, card_number, discount) VALUES
(1, 12345678, 10),
(2, 23456781, 11),
(3, 34567812, 12),
(4, 45678123, 13),
(5, 56781234, 14),
(6, 67812345, 15),
(7, 78123456, 25),
(8, 81234567, 5),
(9, 98765432, 30),
(10, 87654329, 15);

-- 3
INSERT INTO product_category (name) VALUES
('Dairy products'),
('Meat products'),
('Bakery products');

-- 10, min 3 per category
INSERT INTO product_title (title, product_category_id) VALUES
('Milk' ,1),
('Cheese' ,1),
('Butter' ,1),
('Kefir' ,1),
('Beef' ,2),
('Pork' ,2),
('Chicken' ,2),
('Bread', 3),
('Baguette', 3),
('Croissant', 3);

-- 4
INSERT INTO manufacturer (name) VALUES
('Nasha Riaba'),
('Danone'),
('Gala Foods'),
('Chumak');

-- 20
INSERT INTO product (product_title_id, manufacturer_id, price, comment) VALUES
(10, 1, 20.00, 'Ñon fresas'),
(10, 1, 50.00, 'With raspberries'),
(9, 1, 15.00, 'French Baguette'),
(9, 1, 30.00, 'German Baguette'),
(8, 1, 25.00, 'Grey Bread'),
(8, 2, 35.00, 'White Bread'),
(7, 2, 10.00, 'Fresh Chicken'),
(7, 2, 40.00, 'Chicken'),
(6, 2, 45.00, 'Fresh Pork'),
(6, 2, 55.00, 'Pork'),
(5, 3, 60.00, 'Fresh Beef'),
(5, 3, 65.00, 'Beef'),
(4, 3, 70.00, 'Fresh Kefir'),
(4, 3, 75.00, 'Kefir'),
(3, 3, 80.00, 'Fresh Butter'),
(3, 4, 85.00, 'Butter'),
(2, 4, 90.00, 'Fresh Cheese'),
(2, 4, 95.00, 'Cheese'),
(1, 4, 100.00,'Fresh Milk'),
(1, 4, 105.00,'Milk');

-- 20
INSERT INTO customer_order (operation_time, supermarket_id, customer_id) VALUES
('2022-01-01', 1, 1),
('2022-02-02', 1, 1),
('2022-03-03', 1, 2),
('2022-04-04', 2, 3),
('2022-05-05', 2, 3),
('2022-06-06', 2, 4),
('2022-07-07', 3, 5),
('2022-08-08', 3, 6),
('2022-09-09', 3, 7),
('2022-10-10', 4, 7),
('2023-11-11', 4, 8),
('2023-12-12', 4, 9),
('2023-01-13', 5, 10),
('2023-02-14', 5, 10),
('2023-03-15', 5, 10),
('2023-04-16', 5, 10),
('2023-05-17', 6, 10),
('2023-06-18', 6, 10),
('2023-07-19', 7, 10),
('2023-08-20', 7, 10);

-- 20, min 1 per customer_order
INSERT INTO order_details (customer_order_id, product_id, price, price_with_discount, product_amount) VALUES
(1, 1, 1000, 1000, 1),
(2, 2, 1000, 950, 2),
(3, 3, 3000, 950, 3),
(4, 4, 1000, 800, 4),
(5, 5, 1000, 950, 5),
(6, 6, 2000, 800, 6),
(7, 7, 3000, 1000, 7),
(8, 8, 1000, 1000, 1),
(9, 9, 1000, 1000, 2),
(10, 10, 1000, 800, 3),
(11, 11, 3000, 1000, 4),
(12, 12, 1000, 1000, 5),
(13, 13, 1000, 1000, 6),
(14, 14, 3000, 800, 7),
(15, 15, 1000, 950, 1),
(16, 16, 2000, 1000, 2),
(17, 17, 3000, 800, 3),
(18, 18, 1000, 1000, 4),
(19, 19, 1000, 950, 5),
(20, 20, 2000, 1000, 6);