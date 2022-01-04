/*
[8 kyu] Reversed Strings

Complete the solution so that it reverses the string passed into it.
*/

using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char [] strout = str.ToCharArray();
    Array.Reverse(strout);
    string output = new string(strout);
    return output;

  }
}
