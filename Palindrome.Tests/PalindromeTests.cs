using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;
using PalindromeChecker.Check;


namespace PalindromeChecker.Tests
{
  [TestClass]
  public class PalindromeTests
  {

    [TestMethod]
    public void TextConstructor_CreatesInstanceOfText_Text()
    {
      Text newText = new Text();
      Assert.AreEqual(typeof(Text), newText.GetType());
    }

    [TestMethod]
    public void GetText_ReturnsText_String()
    {
      string 
    }
  }
}