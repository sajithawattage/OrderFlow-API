using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public OrderController()
        {

        }

        [HttpGet]
        [Route("order")]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("order/details")]
        public ActionResult Details(int orderNo)
        {
            return Ok();
        }

        [HttpPost]
        [Route("order")]
        public ActionResult Create()
        {
            return Ok();
        }

        [HttpPut]
        [Route("order")]
        public ActionResult Update(int id) 
        { 
            return Ok(); 
        }
    }
}
