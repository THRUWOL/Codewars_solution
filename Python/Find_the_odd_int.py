# https://www.codewars.com/kata/54da5a58ea159efa38000836/train/python

def find_it(seq):
    odds = set() 
    for x in seq: 
        odds.symmetric_difference_update([x]) 
    return list(odds)[0]
