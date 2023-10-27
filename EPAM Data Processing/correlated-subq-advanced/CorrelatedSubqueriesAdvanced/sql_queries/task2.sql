SELECT
    id,
    title,
    count_with_discount_5,
    count_without_discount_5,
    (
        CASE
            WHEN count_with_discount_5 = 0 AND count_without_discount_5 = 0 THEN 0.0
            WHEN count_without_discount_5 = 0 THEN 100.0
            ELSE ROUND((count_with_discount_5 - count_without_discount_5) * 100.0 / (count_with_discount_5 + count_without_discount_5), 2)
        END
    ) AS difference
FROM
(
    SELECT
        p.id,
        p.comment AS title,
        (
            SELECT IFNULL(SUM(od.product_amount), 0) FROM product p1
            LEFT JOIN order_details od ON od.product_id = p1.id
            WHERE p1.id = p.id AND ROUND((od.price - od.price_with_discount) / od.price, 2) > 0.05
        ) AS count_with_discount_5,
        (
            SELECT IFNULL(SUM(od.product_amount), 0) FROM product p1
            LEFT JOIN order_details od ON od.product_id = p1.id
            WHERE p1.id = p.id AND ROUND((od.price - od.price_with_discount) / od.price, 2) <= 0.05
        ) AS count_without_discount_5
    FROM product p
) AS result
ORDER BY id ASC;
