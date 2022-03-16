// https://www.codewars.com/kata/57d814e4950d8489720008db/train/java

public class Kata {
  public static int nthPower(int[] array, int n) {   
    return (n < array.length)? (int)Math.pow(array[n], n): -1;
  }
}
