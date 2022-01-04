/*
[8 kyu] Basic Mathematical Operations

Your task is to create a function that does four basic mathematical operations.
The function should take three arguments - operation(string/char), value1(number), value2(number).
The function should return result of numbers after applying the chosen operation.
*/

namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
      switch(operation){
          case '+':
            return value1+value2;
          case '-':
            return value1-value2;
          case '*':
            return value1*value2;
          default:
            return value1/value2;
      }
    }
  }
}
