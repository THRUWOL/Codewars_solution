/*
[7 kyu] Factorial

In mathematics, the factorial of a non-negative integer n, denoted by n!, is the product of all positive integers less than or equal to n. 
For example: 5! = 5 * 4 * 3 * 2 * 1 = 120. By convention the value of 0! is 1.
Write a function to calculate factorial for a given input. If input is below 0 or above 12 throw an exception of type ArgumentOutOfRangeException
*/

using System;

public static class Kata
{
  public static int Factorial(int n)
  {
    if (n == 0) return 1;
    else if (n < 0 || n > 12) throw new ArgumentOutOfRangeException();
    else return (n * Factorial(n-1));
  }
}
