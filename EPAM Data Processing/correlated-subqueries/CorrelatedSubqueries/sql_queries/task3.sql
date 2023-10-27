SELECT p.id, p.comment AS title, p.price FROM product p
INNER JOIN product_title pt ON pt.id = p.product_title_id
WHERE p.price > (
	SELECT AVG(p1.price) FROM product p1
	INNER JOIN product_title pt1 ON pt1.id = p1.product_title_id
	WHERE pt1.product_category_id = pt.product_category_id
)
ORDER BY p.id;
