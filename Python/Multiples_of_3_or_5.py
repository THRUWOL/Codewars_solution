# https://www.codewars.com/kata/514b92a657cdc65150000006/train/python

def solution(number):
    number -=1
    counter = 0
    while number > 0:
        if number % 3 == 0 or number % 5 == 0:
            counter += number
        number -= 1
    return counter
