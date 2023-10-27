SELECT  person.surname,
        person.name,
        SUM(order_details.price_with_discount * order_details.product_amount) AS total_expenses
FROM customer_order
INNER JOIN customer ON customer_order.customer_id = customer.person_id
INNER JOIN person ON customer.person_id = person.id
INNER JOIN order_details ON customer_order.id = order_details.customer_order_id
WHERE person.birth_date BETWEEN '2000-01-01' AND '2010-12-31'
GROUP BY person.surname, person.name
HAVING total_expenses > (
    SELECT AVG(sum_price)
    FROM (
        SELECT
        SUM(order_details.product_amount * order_details.price) AS sum_price
        FROM customer_order
        INNER JOIN order_details ON customer_order.id = order_details.customer_order_id
        LEFT JOIN person ON person.id = customer_order.customer_id
        GROUP BY person.id
    ) AS t
)
ORDER BY total_expenses, person.surname;
