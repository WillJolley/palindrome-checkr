using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;
using System;
// using PalindromeChecker.Check;


namespace PalindromeChecker.Tests
{
  [TestClass]
  public class PalindromeCheckerTests
  {

    [TestMethod]
    public void TextConstructor_CreatesInstanceOfText_Text()
    {
      Text newText = new Text("word");
      Assert.AreEqual(typeof(Text), newText.GetType());
    }

    [TestMethod]
    public void GetText_ReturnsText_String()
    {
      string word = "meow";
      Text newText = new Text(word);
      string result = newText.Word;
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public static void IsPalindrome_PalindromeString_ReturnsTrue()
    {
        // Arrange
        string word = "racecar";

        // Act
        bool isPalindrome = PalindromeChecker.IsPalindrome(word);

        // Assert
        Assert.IsTrue(isPalindrome);
    }
  }
}