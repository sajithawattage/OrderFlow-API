using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        [HttpGet]
        [Route("configuration")]
        public IActionResult Get()
        {
            return Ok(new { Version = "1.0.3"});
        }
    }
}
