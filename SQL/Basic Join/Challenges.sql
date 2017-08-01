SELECT h.hacker_id,
         h.name,
         count(*) AS Counter
FROM hackers h
JOIN challenges c
    ON h.hacker_id = c.hacker_id
GROUP BY  h.hacker_id, h.name
HAVING Counter = 
    (SELECT COUNT(ci.challenge_id) AS contadorI
    FROM hackers hi
    JOIN challenges ci
        ON hi.hacker_id = ci.hacker_id
    GROUP BY  hi.hacker_id
    ORDER BY  contadorI DESC LIMIT 1 )
        OR Counter NOT IN 
    (SELECT COUNT(c2.challenge_id)
    FROM challenges c2
    GROUP BY  c2.hacker_id
    HAVING c2.hacker_id <> h.hacker_id )
ORDER BY  Counter DESC, h.hacker_id ;