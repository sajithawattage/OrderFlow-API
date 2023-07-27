using Microsoft.AspNetCore.Mvc;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Controllers
{
    [Route("api")]
    [JwtAuthorize]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("customer")]
        public IActionResult Get()
        {
            var customerList = _customerService.GetCustomersByRepCode();
            return Ok(new CustomerListResponse
            {
                body = customerList,
                isError = false,
                message = string.Empty
            });
        }

        [HttpGet]
        [Route("customer/loadcustomerimage")]
        public ActionResult LoadCustomerImage(int customerCode) { return Ok(); }

        [HttpPost]
        [Route("customer")]
        public ActionResult Create(CustomerRequest request)
        {
            _customerService.CreateCustomer(request);
            return Ok();
        }

        [HttpPut]
        [Route("customer")]
        public ActionResult Update(CustomerRequest request)
        {
            _customerService.UpdateCustomer(request);
            return Ok();
        }

    }
}
