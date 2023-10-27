SELECT city.name as city, SUM(price_with_discount * product_amount) AS income
FROM order_details
INNER JOIN customer_order ON order_details.customer_order_id = customer_order.id
INNER JOIN supermarket ON customer_order.supermarket_id = supermarket.id
INNER JOIN street ON supermarket.street_id = street.id
INNER JOIN city ON street.city_id = city.id
WHERE customer_order.operation_time BETWEEN '2020-11-01' AND '2020-11-30'
GROUP BY city.id
ORDER BY income, city;