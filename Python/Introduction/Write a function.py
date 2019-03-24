def is_leap(year):
    leap = False
    
    # Write your logic here
    if year % 4 is 0:
        leap = True
    if year % 100 is 0:
        leap = False
        if year % 400 is 0:
            leap = True

    return leap

year = int(input())
print(is_leap(year))