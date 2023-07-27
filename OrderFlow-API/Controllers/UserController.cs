using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [JwtAuthorize]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("user")]
        public ActionResult Create()
        {
            return Ok();
        }

        [HttpPut]
        [Route("user/changepassword")]
        public ActionResult ChangePassword() 
        {
            return Ok();
        }
    }
}
