SELECT person.surname, person.name, 0 AS sum
FROM customer
INNER JOIN person ON person.id = customer.person_id
LEFT JOIN customer_order ON person.id = customer_order.customer_id
LEFT JOIN order_details ON customer_order.id = order_details.customer_order_id
WHERE customer_order.id IS NULL
GROUP BY person.id
UNION
SELECT person.surname, person.name, SUM(order_details.product_amount * order_details.price_with_discount) AS sum
FROM customer_order
INNER JOIN order_details ON customer_order.id = order_details.customer_order_id
LEFT JOIN person ON person.id = customer_order.customer_id
GROUP BY person.id
ORDER BY SUM(order_details.product_amount * order_details.price_with_discount), person.surname;