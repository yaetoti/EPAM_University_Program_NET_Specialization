SELECT product.id, product_title.title, product_category.name AS category, product.price FROM product
INNER JOIN product_title ON product.product_title_id = product_title.id
INNER JOIN product_category ON product_title.product_category_id = product_category.id
ORDER BY product_category.name, title;