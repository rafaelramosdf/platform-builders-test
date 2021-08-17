using PlatformBuildersTest.Domain.Entities;

namespace PlatformBuildersTest.Domain.Contracts.Services
{
    public interface IPalindromeService
    {
        public PalindromeEntity CheckPalindrome(PalindromeEntity entity);
    }
}
