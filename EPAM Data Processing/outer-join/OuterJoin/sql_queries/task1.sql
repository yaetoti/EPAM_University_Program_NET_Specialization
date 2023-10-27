SELECT product_category.name AS category, product_title.title AS product
FROM product
LEFT JOIN order_details ON order_details.product_id = product.id
INNER JOIN product_title ON product.product_title_id = product_title.id
INNER JOIN product_category ON product_title.product_category_id = product_category.id
WHERE order_details.product_id IS NULL
ORDER BY product.id;