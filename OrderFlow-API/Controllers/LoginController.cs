using Microsoft.AspNetCore.Mvc;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Post(LoginRequestViewModel user)
        {
            IActionResult response = Unauthorized();
            var loginResponse = _userService.GetUserByCredentials(user.username, user.password);
            return Ok(loginResponse);
        }
    }
}
