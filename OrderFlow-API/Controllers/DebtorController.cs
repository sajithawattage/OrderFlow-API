using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [JwtAuthorize]
    [ApiController]
    public class DebtorController : ControllerBase
    {
        public DebtorController()
        {

        }

        [HttpGet]
        [Route("debtor")]
        public ActionResult LoadDebtorList(int customerCode) 
        {
            return Ok();
        }
    }
}
