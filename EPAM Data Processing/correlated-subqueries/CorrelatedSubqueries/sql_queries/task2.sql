SELECT pc.id, pc.name FROM product_category pc
WHERE EXISTS (
	SELECT * FROM product p
	INNER JOIN product_title pt ON pt.id = p.product_title_id
	WHERE pt.product_category_id = pc.id
)
AND
NOT EXISTS (
	SELECT p.id FROM product p
	INNER JOIN product_title pt ON pt.id = p.product_title_id
	LEFT JOIN order_details od ON p.id = od.product_id
	WHERE pt.product_category_id = pc.id AND od.product_id IS NULL
)
ORDER BY pc.id;
