SELECT concat(Name,
         '(',left(Occupation,1),')') AS New
FROM Occupations
ORDER BY  New;SELECT concat('There are a total of ',count(Occupation),' ',lower(Occupation),'s.') AS New
FROM Occupations
GROUP BY  Occupation
ORDER BY  count(Occupation),Occupation;