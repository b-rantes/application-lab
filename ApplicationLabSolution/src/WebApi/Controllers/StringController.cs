using Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StringController : Controller
    {
        private readonly IStringManagerService _stringManagerService;

        public StringController(IStringManagerService stringManagerService)
        {
            _stringManagerService = stringManagerService;
        }

        [HttpGet]
        public IActionResult GetString()
        {
            var result = _stringManagerService.GetString();
            
            return Ok(result);
        }

        [HttpPost]
        public IActionResult SetStringAsync([FromBody] SetStringRequest request)
        {
            _stringManagerService.SetString(request.Value);

            return Ok();
        }
    }

    public class SetStringRequest
    {
        public string Value { get; set; }
    }
}
