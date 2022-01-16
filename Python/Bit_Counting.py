#https://www.codewars.com/kata/526571aae218b8ee490006f4/train/python

def count_bits(n):
    return len(str(bin(n)).replace('0b',"").replace("0",""))
