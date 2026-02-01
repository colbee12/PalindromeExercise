using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


namespace PalindromeExercise
{
   public class WordSmith
   {
      public bool IsPalindrome(string word)
      {
         string reversedWord = "";

         for (int i = word.Length - 1; i >= 0; i--)
         {
            reversedWord += word[i];
         }

         if (word == reversedWord)
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
