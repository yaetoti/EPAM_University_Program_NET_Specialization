SELECT product_category.name AS category, COUNT(*) AS count FROM product
INNER JOIN product_title ON product.product_title_id = product_title.id
INNER JOIN product_category ON product_title.product_category_id = product_category.id
GROUP BY category
HAVING count > 0
ORDER BY category;