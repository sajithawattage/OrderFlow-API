using Microsoft.AspNetCore.Mvc;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        [Route("item")]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("item/getImage")]
        public ActionResult LoadItemImage(int itemCode)
        {
            return Ok();
        }
    }
}
