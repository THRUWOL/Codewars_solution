/*
[7 kyu] Sum of all the multiples of 3 or 5

Your task is to write function findSum.
Upto and including n, this function will return the sum of all multiples of 3 and 5.
*/

namespace Solution
{
  public static class Program
  {
    public static int findSum(int n)
    {
      int sum = 0;
      for (int i = 1; i <= n; i++)
        if (i % 3 == 0 || i % 5 == 0) sum += i;
      return sum;
    }
  }
}
