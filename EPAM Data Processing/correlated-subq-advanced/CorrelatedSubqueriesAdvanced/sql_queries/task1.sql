SELECT
	p.name,
	p.surname,
	(
		SELECT ROUND(AVG(od.price_with_discount * od.product_amount), 2) FROM customer_order co
		LEFT JOIN order_details od ON od.customer_order_id = co.id
		WHERE co.customer_id = p.id OR (co.customer_id IS NULL AND p.id IS NULL)
	) AS avg_purchase,
	(
		SELECT SUM(od.price_with_discount * od.product_amount) FROM customer_order co
		LEFT JOIN order_details od ON od.customer_order_id = co.id
		WHERE co.customer_id = p.id OR (co.customer_id IS NULL AND p.id IS NULL)
	) AS sum_purchase
FROM customer_order co
LEFT JOIN customer c ON c.person_id = co.customer_id
LEFT JOIN person p ON p.id = co.customer_id
GROUP BY p.name, p.surname
HAVING avg_purchase > 70
ORDER BY sum_purchase, p.surname;
