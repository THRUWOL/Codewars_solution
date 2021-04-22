/*
[7 kyu] Is this a triangle?

Implement a method that accepts 3 integer values a, b, c. 
The method should return true if a triangle can be built with the sides of given length and false in any other case.
*/

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c) => a < b+c && b < a+c && c < a+b? true: false;
}
