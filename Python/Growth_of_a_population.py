#https://www.codewars.com/kata/563b662a59afc2b5120000c6/train/python

def nb_year(population, percent, aug, target):
    year = 0
    while population < target:
        population += population * percent / 100. + aug
        year += 1
    return year
