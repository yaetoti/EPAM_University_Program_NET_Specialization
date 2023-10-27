SELECT	person.surname,
		person.name,
		person.birth_date,
		SUM(order_details.price * order_details.product_amount) as sum
FROM order_details
INNER JOIN customer_order ON order_details.customer_order_id = customer_order.id
INNER JOIN customer ON customer_order.customer_id = customer.person_id
INNER JOIN person ON customer.person_id = person.id
WHERE customer.discount = 0 AND customer_order.operation_time BETWEEN '2021-01-01' AND '2021-12-31'
GROUP BY person.id
ORDER BY sum, person.surname;
