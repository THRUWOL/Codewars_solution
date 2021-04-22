/*
[5 kyu] Valid Parentheses

Write a function that takes a string of parentheses, and determines if the order of the parentheses is valid. 
The function should return true if the string is valid, and false if it's invalid.
*/

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
      var count = 0;
        foreach(var c in input)
        {
          if(count == -1) return false;
          if(c == '(') count++;
          if(c == ')') count --;
        }
      return count == 0;
    }
}
