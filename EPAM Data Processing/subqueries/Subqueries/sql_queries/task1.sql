SELECT product.id, product_title.title AS product, product.price
FROM product
INNER JOIN product_title ON product.product_title_id = product_title.id
WHERE product.price >= 2 * (SELECT MIN(price) FROM product)
ORDER BY product.price, product_title.title;