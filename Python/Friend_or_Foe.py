# https://www.codewars.com/kata/55b42574ff091733d900002f/solutions/python

def friend(x):
    new_friends = []
    for str in x:
        if len(str) == 4: new_friends.append(str)
    return new_friends
