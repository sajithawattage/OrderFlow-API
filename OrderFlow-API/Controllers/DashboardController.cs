using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [JwtAuthorize]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        public DashboardController() { }

        [HttpGet]
        [Route("dashboard/target")]
        public ActionResult LoadSalesTarget()
        {
            return Ok();
        }

        [HttpGet]
        [Route("dashboard")]
        public ActionResult LoadSalesSummary(int repCode) { return Ok(); }

        [HttpGet]
        [Route("dashboard/category")]
        public ActionResult LoadSalesCategories(int repCode) { return Ok(); }
    }
}
