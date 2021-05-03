/*
[8 kyu] Convert boolean values to strings 'Yes' or 'No'.

Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
*/

using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word) => word == true ? "Yes": "No";
}
