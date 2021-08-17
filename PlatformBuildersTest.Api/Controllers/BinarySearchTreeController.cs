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
    [Route("binary-search-trees")]
    [Produces("application/json")]
    public class BinarySearchTreeController : ControllerBase
    {
        private readonly ILogger<BinarySearchTreeController> _logger;
        private readonly IBinarySearchTreeService _binarySearchTreeService;

        public BinarySearchTreeController(ILogger<BinarySearchTreeController> logger,
            IBinarySearchTreeService binarySearchTreeService)
        {
            _logger = logger;
            _binarySearchTreeService = binarySearchTreeService;
        }

        [HttpGet("{value:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BinarySearchTreeNodeEntity))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProblemDetails))]
        public IActionResult Get(int value)
        {
            try
            {
                if (value < 1)
                    return Problem("Informe o parâmetro 'value'", null, StatusCodes.Status400BadRequest, HttpStatusCode.BadRequest.ToString());

                var binarySearchTreeNodeResult = _binarySearchTreeService.Get(value);
                return Ok(binarySearchTreeNodeResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message, value);
                return Problem(ex.InnerException?.Message, value.ToString(), StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
