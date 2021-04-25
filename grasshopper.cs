/*
[8 kyu] Grasshopper - Summation

Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.
*/

using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int outp = 0;
      for(int i = 0; i <= num; i++) outp += i;
      return outp;
    }
}
