# https://www.codewars.com/kata/5264d2b162488dc400000001/train/python

def spin_words(sentence):
    list = sentence.split()
    strings = ""
    for word in list:
        if len(word) < 5: strings = strings +" "+ word
        if len(word) >= 5: strings = strings + " "+(word[::-1])
    return(strings.lstrip())
