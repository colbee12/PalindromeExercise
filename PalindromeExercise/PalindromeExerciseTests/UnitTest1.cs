using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using PalindromeExercise;
using Xunit;


namespace PalindromeExerciseTests
{

    public class WordSmithTest
    {
        [Theory]
        [InlineData("eye", true)]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("apple", false)]
        [InlineData("banana", false)]
        public void IsPalindromeTest(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }

}