# https://www.codewars.com/kata/5dd462a573ee6d0014ce715b/train/python

def same_case(a, b): 
    if a.isalpha() != True or b.isalpha() != True:
        return -1
    else:
        return 1 if a.isupper() and b.isupper() or a.islower() and b.islower() else 0
