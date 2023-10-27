SELECT COUNT(*) AS customer_count, discount FROM CUSTOMER
GROUP BY discount
ORDER BY discount;