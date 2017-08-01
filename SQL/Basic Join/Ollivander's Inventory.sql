SELECT W.id,
         P.age,
         W.coins_needed,
         W.power
FROM Wands W
JOIN Wands_Property P
USING (code)
JOIN 
    (SELECT W.power,
         MIN(W.coins_needed) AS min_coins,
        P.age
    FROM Wands W
    JOIN Wands_Property P USING(code)
    WHERE P.is_evil = 0
    GROUP BY  W.power,P.age) AS mins
    ON W.power = mins.power
        AND W.coins_needed = mins.min_coins
        AND P.age=mins.age
WHERE p.is_evil=0
ORDER BY  W.power DESC, P.age DESC