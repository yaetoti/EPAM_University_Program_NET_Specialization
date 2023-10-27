SELECT
SUM(product_amount) AS product_total,
SUM(product_amount * price_with_discount) AS to_pay_total,
SUM(product_amount * price - product_amount * price_with_discount) AS discount_total
FROM order_details
WHERE price <> price_with_discount;