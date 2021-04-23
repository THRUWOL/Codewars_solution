/*
[5 kyu] Rot13

ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.
Create a function that takes a string and returns the string ciphered with Rot13. 
If there are numbers or special characters included in the string, they should be returned as they are. 
Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
*/

using System;
using System.Text;

public class Kata
{
  public static string Rot13(string message)
  {
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < message.Length; i++)
    {
      if (Char.IsLetter(message[i]))
      {
        if ((message[i] > 64 && message[i] < 78) || (message[i] > 96 && message[i] < 110)) sb.Append((char)(message[i] + 13));
        else sb.Append((char)(message[i] - 13));
      }
      else sb.Append(message[i]);
    }
    return sb.ToString();
  }
}
