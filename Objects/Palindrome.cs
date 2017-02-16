using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class PalindromeCheck
  {
    public bool Check(string word)
    {
      // char[] charArray1 = word.ToLower().ToCharArray();
      char[] charArray = word.ToLower().ToCharArray();
      // Array.Reverse(charArray);
      // if (string.Join("", charArray) == string.Join("", charArray1))
      // {
      //   return true;
      // }
      //   else
      //   {
      //     return false;
      //   }
      if (word.Length > 1)
      {
        int i = 0;
        while(i < word.Length)
        {
          if (string.Join("", charArray[i]) == string.Join("", charArray[word.Length-1-i]))
          {
            i++;
          }
          else{
            return false;
          }
        }
        return true;
      }
      else
      {
        return true;
      }
    }
  }
}
