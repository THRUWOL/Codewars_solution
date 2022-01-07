# https://www.codewars.com/kata/525c65e51bf619685c000059/train/python

def cakes(recipe, available):
    return min([available[i] // recipe[i] if i in available else 0 for i in recipe])
