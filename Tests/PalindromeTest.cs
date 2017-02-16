using System;
using System.Collections.Generic;
using Xunit;

namespace Palindrome
{
  public class PalindromeTest
  {
    [Fact]
    public void GetWord_CheckPalindrome_True()
    {
      //Arrange
      PalindromeCheck testPalindromeCheck = new PalindromeCheck();
      //Act
      Assert.Equal(true, testPalindromeCheck.Check("a"));
      //Assert

    }
    [Fact]
    public void GetWord_CheckNotPalindrome_False()
    {
      //Arrange
      PalindromeCheck testPalindromeCheck = new PalindromeCheck();
      //Act
      Assert.Equal(false, testPalindromeCheck.Check("Hello"));
      //Assert

    }
  }
}
