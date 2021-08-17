using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlatformBuildersTest.Domain.Contracts.Services;
using PlatformBuildersTest.Domain.Entities;
using System;
using System.Net;

namespace PlatformBuildersTest.Api.Controllers
{
    [ApiController]
    [Route("palindrome-checks")]
    [Produces("application/json")]
    public class PalindromeController : ControllerBase
    {
        private readonly ILogger<PalindromeController> _logger;
        private readonly IPalindromeService _palindromeService;

        public PalindromeController(ILogger<PalindromeController> logger,
            IPalindromeService palindromeService)
        {
            _logger = logger;
            _palindromeService = palindromeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PalindromeEntity))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProblemDetails))]
        public IActionResult Get([FromQuery] string text)
        {
            try
            {
                if (string.IsNullOrEmpty(text))
                    return Problem("Informe o parâmetro 'text'", null, StatusCodes.Status400BadRequest, HttpStatusCode.BadRequest.ToString());

                var palindrome = new PalindromeEntity(text);
                var palindromeResult = _palindromeService.CheckPalindrome(palindrome);
                return Ok(palindromeResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message, text);
                return Problem(ex.InnerException?.Message, text, StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
