# https://www.codewars.com/kata/52fba66badcd10859f00097e/train/python

def disemvowel(string_):
    for string in string_:
        if string in 'aueoiAUEOI':
            string_ = string_.replace(string, "")
    return string_
