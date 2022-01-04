/*
[7 kyu] Odd or Even?

Given a list of integers, determine whether the sum of its elements is odd or even.
Give your answer as a string matching "odd" or "even".
If the input array is empty consider it as: [0] (array with a zero).
*/

public class Kata
{
  public static string OddOrEven(int[] array)
  {
    int temp = 0;
    for (int i = 0; i < array.Length; i++) temp += array[i];
    if (temp % 2  == 0) return "even";
    else return "odd";
  }
}
