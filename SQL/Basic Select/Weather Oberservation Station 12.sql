SELECT DISTINCT(CITY) FROM STATION WHERE 
NOT (UPPER(CITY) LIKE 'A%' OR UPPER(CITY) LIKE 'E%' OR UPPER(CITY) LIKE 'I%' OR UPPER(CITY) LIKE 'O%' OR UPPER(CITY) LIKE 'U%')
 AND 
NOT (UPPER(CITY) LIKE '%A' OR UPPER(CITY) LIKE '%E' OR UPPER(CITY) LIKE '%I' OR UPPER(CITY) LIKE '%O' OR UPPER(CITY) LIKE '%U');