Regex_Pattern = r'^\d{1,2}[A-Z|a-z]{3,}[.]{0,3}$'	# Do not delete 'r'.
import re
print(str(bool(re.search(Regex_Pattern, input()))).lower())