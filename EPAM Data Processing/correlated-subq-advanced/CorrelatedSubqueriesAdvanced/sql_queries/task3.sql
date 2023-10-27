SELECT
    pt.id AS product_id,
    pt.title,
    (
        SELECT m.id
        FROM order_details od
        JOIN product p ON od.product_id = p.id
        JOIN manufacturer m ON p.manufacturer_id = m.id
        WHERE p.product_title_id = pt.id
        GROUP BY m.id
        ORDER BY SUM(od.product_amount) DESC
        LIMIT 1
    ) AS manufacturer_id,
    (
        SELECT m.name
        FROM order_details od
        JOIN product p ON od.product_id = p.id
        JOIN manufacturer m ON p.manufacturer_id = m.id
        WHERE p.product_title_id = pt.id
        GROUP BY m.id
        ORDER BY SUM(od.product_amount) DESC
        LIMIT 1
    ) AS manufacturer
FROM product_title pt
ORDER BY pt.id ASC;
