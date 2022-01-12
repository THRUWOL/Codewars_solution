# https://www.codewars.com/kata/567bf4f7ee34510f69000032

def is_digit(n):
    if n.isdigit():
        if int(n) <= 9 and int(n) >= 0:
            return True
        else: return False
    else: return False  
