# My Answer
import math

def round_it(n):
    s = str(n)
    afterDecimal = len(s) - s.index('.') - 1 
    beforeDecimal = len(s) - afterDecimal - 1
    if afterDecimal > beforeDecimal:
        return math.ceil(n)
    elif afterDecimal < beforeDecimal:
        return math.floor(n)
    else:
        return round(n)

# Top Answer

from math import ceil

def round_it_two(n):
    a, b = map(len, str(n).split('.'))
    if a > b:
        return int(n)
    if b > a:
        return ceil(n)
    return round(n)