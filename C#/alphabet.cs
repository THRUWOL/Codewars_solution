/*
[6 kyu] Replace With Alphabet Position

In this kata you are required to, given a string, replace every letter with its position in the alphabet.
If anything in the text isn't a letter, ignore it and don't return it.
"a" = 1, "b" = 2, etc.
*/

using System.Linq;
public static class Kata
{
  public static string AlphabetPosition(string text) => string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
}
