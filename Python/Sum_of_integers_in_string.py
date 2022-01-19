# https://www.codewars.com/kata/598f76a44f613e0e0b000026/train/python

import re
def sum_of_integers_in_string(s):
    sum=0
    for i in range(len(re.findall('[0-9]+',s))):
        sum +=int(re.findall('[0-9]+',s)[i])
    return sum
