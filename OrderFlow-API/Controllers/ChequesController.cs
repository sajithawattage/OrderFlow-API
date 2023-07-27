using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [JwtAuthorize]
    [ApiController]
    public class ChequesController : ControllerBase
    {
        private readonly IChequeService _chequeService;

        public ChequesController(IChequeService chequeService)
        {
            _chequeService = chequeService;
        }

        [HttpGet]
        [Route("cheques")]
        public IActionResult Get()
        {
            var returnCheques = _chequeService.GetReturnCheques();
            return Ok(new ReturnChequeResponse { body = returnCheques, isError = false, message = string.Empty });
        }
    }
}
