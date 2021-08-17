using PlatformBuildersTest.Domain.Contracts.Services;
using PlatformBuildersTest.Domain.Entities;
using System;

namespace PlatformBuildersTest.Service.Services
{
    public class PalindromeService : IPalindromeService
    {
        public PalindromeEntity CheckPalindrome(PalindromeEntity entity)
        {
            if (string.IsNullOrEmpty(entity.Text))
                return entity;

            var reverseText = entity.GetReverseText();
            var isPalindrome = reverseText == entity.Text.ToLower();
            entity.SetPalindrome(isPalindrome);
            return entity;
        }
    }
}
