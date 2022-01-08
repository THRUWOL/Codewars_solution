# https://www.codewars.com/kata/52685f7382004e774f0001f7/train/python

def make_readable(seconds):
    minutes = seconds // 60
    seconds = seconds % 60
    hours = minutes // 60
    minutes = minutes % 60
    
    return(f"{double_number(hours)}:{double_number(minutes)}:{double_number(seconds)}")
    
def double_number(number):
    if number // 10 == 0:
        return(f"0{number}")
    else:
        return(f"{number}")
