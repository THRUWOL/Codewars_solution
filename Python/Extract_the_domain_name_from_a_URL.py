# https://www.codewars.com/kata/514a024011ea4fb54200004b/train/python

def domain_name(url):
    x = url.replace('http://','').replace('https://','').replace('www.','')
    dot = (x.find('.'))
    
    return x[:dot]
