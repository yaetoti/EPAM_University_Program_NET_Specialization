SELECT person.surname, person.name, person.birth_date FROM customer
LEFT JOIN customer_order ON customer_order.customer_id = customer.person_id
INNER JOIN person ON person.id = customer.person_id
WHERE customer_order.customer_id IS NULL
ORDER BY person.surname, person.birth_date;