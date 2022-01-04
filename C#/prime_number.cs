/*
[6 kyu] Is a number prime?

Define a function that takes one integer argument and returns logical value true or false depending on if the integer is a prime.
Requirements
* You can assume you will be given an integer input.
* You can not assume that the integer will be only positive. You may be given negative numbers as well (or 0).
* NOTE on performance: There are no fancy optimizations required, but still the most trivial solutions might time out. 
  Numbers go up to 2^31 (or similar, depends on language version). Looping all the way up to n, or n/2, will be too slow.
*/

using System;

public static class Kata
{
  public static bool IsPrime(int num)
  {
    if (num < 2) return false;
    else if (num == 2) return true;
    if (num % 2 == 1)
    {
      for (int i=2; i<=(Math.Sqrt(num)); i++)
        if(num % i == 0)
        {
          return false;
          break;
        }
    } 
    else return false;
  return true;
  }
}
