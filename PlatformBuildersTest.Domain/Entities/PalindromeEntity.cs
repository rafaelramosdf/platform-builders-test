using System;
using System.Linq;

namespace PlatformBuildersTest.Domain.Entities
{
    public class PalindromeEntity
    {
        public PalindromeEntity(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
        public bool IsPalindrome { get; private set; }

        public void SetPalindrome(bool isPalindrome)
        {
            IsPalindrome = isPalindrome;
        }

        public string GetReverseText()
        {
            return string.Join("", Text.Reverse().ToArray()).ToLower();
        }
    }
}
