# https://www.codewars.com/kata/5526fc09a1bbd946250002dc/train/python

def find_outlier(integers):
    odd = []
    even = []
    for number in integers:
        if number % 2 == 0: even.append(number)
        else: odd.append(number)
    if len(odd) > len(even): return(even[0])
    else: return(odd[0])
        
