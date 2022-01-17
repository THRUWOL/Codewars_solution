# https://www.codewars.com/kata/513e08acc600c94f01000001/train/python

def rgb(r, g, b):
    def convert(x):
        if x < 0:
            return '00'
        if x > 255:
            return 'FF'
        else:
            return hex(x)[2:].upper()
    def convertToHex (x):
        if len(str(convert(x))) == 1:
            return '0'+str(convert(x))
        else:
            return str(convert(x))
        
    return f"{convertToHex(r)}{convertToHex(g)}{convertToHex(b)}"
