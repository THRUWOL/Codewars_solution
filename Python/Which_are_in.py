# https://www.codewars.com/kata/550554fd08b86f84fe000a58/train/python

def in_array(array1, array2):
    r = []
    for element2 in array2:
        for element1 in array1:
            if element1 in element2:
                if element1 not in r:
                    r.append(element1)
    return(sorted(r))
