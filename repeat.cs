/*
[8 kyu] String repeat

Write a function called repeatStr which repeats the given string string exactly n times.
*/

using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s) => string.Concat(Enumerable.Repeat(s,n));
  }
}
