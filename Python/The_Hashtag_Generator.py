# https://www.codewars.com/kata/52449b062fb80683ec000024/train/python

def generate_hashtag(s):
    return s and not len(s) > 140 and "#"+s.title().replace(' ','') or False
