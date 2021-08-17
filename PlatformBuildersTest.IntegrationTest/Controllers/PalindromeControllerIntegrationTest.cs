using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using PlatformBuildersTest.Api.Controllers;
using PlatformBuildersTest.Domain.Contracts.Services;
using System.Threading.Tasks;
using Xunit;

namespace PlatformBuildersTest.IntegrationTest.Controllers
{
    public class PalindromeControllerIntegrationTest
    {
        private readonly Mock<IPalindromeService> _palindromeService;
        private readonly Mock<ILogger<PalindromeController>> _logger;

        public PalindromeControllerIntegrationTest()
        {
            _logger = new Mock<ILogger<PalindromeController>>();
            _palindromeService = new Mock<IPalindromeService>();
        }

        [Fact]
        public async Task must_return_status_success_test()
        {
            var controller = new PalindromeController(_logger.Object, _palindromeService.Object);
            var serviceResult = controller.Get("teste");

            var actionResult = Assert.IsType<OkObjectResult>(serviceResult);

            Assert.NotNull(serviceResult);
            Assert.Equal(StatusCodes.Status200OK, actionResult.StatusCode);
        }

        [Fact]
        public async Task must_return_status_badrequest_test()
        {
            var controller = new PalindromeController(_logger.Object, _palindromeService.Object);
            var serviceResult = controller.Get(null);

            var actionResult = Assert.IsType<ObjectResult>(serviceResult);

            Assert.NotNull(serviceResult);
            Assert.Equal(StatusCodes.Status400BadRequest, actionResult.StatusCode);
        }
    }
}
