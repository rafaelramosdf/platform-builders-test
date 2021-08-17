using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlatformBuildersTest.Domain.Contracts.Services;
using PlatformBuildersTest.Domain.Entities;
using System;

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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(BinarySearchTreeNodeEntity))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProblemDetails))]
        public IActionResult Post([FromBody] BinarySearchTreeNodeEntity model)
        {
            try
            {
                var binarySearchTreeNodeResult = _binarySearchTreeService.Add(model);
                return Created($"binary-search-trees/{binarySearchTreeNodeResult.Id}", binarySearchTreeNodeResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message, model);
                return Problem(ex.InnerException?.Message, null, StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{value:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BinarySearchTreeNodeEntity))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ProblemDetails))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProblemDetails))]
        public IActionResult Get(int value)
        {
            try
            {
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
