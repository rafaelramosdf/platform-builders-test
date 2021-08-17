using PlatformBuildersTest.Domain.Contracts.Services;
using PlatformBuildersTest.Domain.Entities;
using PlatformBuildersTest.Service.Services;
using System.Threading.Tasks;
using Xunit;

namespace PlatformBuildersTest.UnitTest.Services
{
    public class PalindromeServiceUnitTest
    {
        private IPalindromeService _palindromeService;

        public PalindromeServiceUnitTest()
        {
            _palindromeService = new PalindromeService();
        }

        [Fact]
        public async Task must_return_false_palindrome_test()
        {
            var palindrome = new PalindromeEntity("not");
            var palindromeResult = _palindromeService.CheckPalindrome(palindrome);

            var expectedResult = false;
            Assert.True(expectedResult == palindromeResult.IsPalindrome);
        }

        [Fact]
        public async Task must_return_true_palindrome_test()
        {
            var palindrome = new PalindromeEntity("yesey");
            var palindromeResult = _palindromeService.CheckPalindrome(palindrome);

            var expectedResult = true;
            Assert.True(expectedResult == palindromeResult.IsPalindrome);
        }
    }
}
