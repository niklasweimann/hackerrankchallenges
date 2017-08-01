SELECT
    CASE
    WHEN g.grade < 8 THEN
    null
    ELSE s.name end, g.grade, s.marks
FROM students AS s
JOIN grades AS g
    ON s.marks >= g.min_mark
        AND s.marks <= g.max_mark
ORDER BY  g.grade desc, s.name asc