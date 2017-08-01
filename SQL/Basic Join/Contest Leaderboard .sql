SELECT h.hacker_id,
         h.name,
         SUM(s.max_score) AS SumMaxScore
FROM hackers h
JOIN 
    (SELECT si.hacker_id AS hacker_id,
         si.challenge_id AS challenge_id,
         MAX(si.score) max_score
    FROM submissions si
    GROUP BY  si.hacker_id, si.challenge_id
    HAVING max_score > 0 ) AS s
    ON h.hacker_id = s.hacker_id
GROUP BY  h.hacker_id, h.name
ORDER BY  SumMaxScore DESC, h.hacker_id;