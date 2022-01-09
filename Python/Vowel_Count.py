# https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/python

def get_count(sentence):
    counter = 0
    for letter in sentence:
        if letter in ('aeoui'): counter +=1
    return counter
