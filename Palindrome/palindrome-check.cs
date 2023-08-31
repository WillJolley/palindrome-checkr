using System;

namespace PalindromeChecker
{
  public class PalindromeChecker
  {
    private string _word;
    public string Word
    {
      get {return _word; }
    }

    public Text(string word)
    {
      _word = word;
    }

    // public static bool IsPalindrome(string word)
    // {
    //   char[] charArray = word.ToCharArray();
    //   Array.Reverse(charArray);
    //   string reversedWord = new string(charArray);
    //   return word == reversedWord;
    // }
    public static bool IsPalindrome(string word)
    {
      return true;
    }
  }
}