using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class PalindromeCheck
  {
    public bool Check(string word)
    {
      char[] charArray1 = word.ToLower().ToCharArray();
      char[] charArray = word.ToLower().ToCharArray();
      Array.Reverse(charArray);
      if (string.Join("", charArray) == string.Join("", charArray1))
      {
        return true;
      }
        else
        {
          return false;
        }
    }
  }
}
