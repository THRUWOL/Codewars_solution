/*
[8 kyu] Return Negative

In this simple assignment you are given a number and have to make it negative. But maybe the number is already negative?
*/

using System;

public static class Kata
{
  public static int MakeNegative(int number) => number > 0 ? -number: number;
}
