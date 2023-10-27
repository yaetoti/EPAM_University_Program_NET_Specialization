SELECT customer_order.id AS order_id, COUNT(order_details.id) AS items_count
FROM customer_order
INNER JOIN order_details ON customer_order.id = order_details.customer_order_id
WHERE strftime('%Y', customer_order.operation_time) = '2021'
GROUP BY customer_order.id
HAVING COUNT(order_details.id) > (
    SELECT AVG(items_per_order)
    FROM (
        SELECT COUNT(order_details.id) AS items_per_order
        FROM customer_order
        INNER JOIN order_details order_details ON customer_order.id = order_details.customer_order_id
        GROUP BY customer_order.id
    ) AS t
)
ORDER BY items_count, order_id;
