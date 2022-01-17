# https://www.codewars.com/kata/520b9d2ad5c005041100000f/solutions/python

def pig_it(text):
    string = ""
    for word in text.split():
        if word not in "?!":
            string += word[1:] + word[:1] + 'ay '
        else:
            string += word
    return string.rstrip()
