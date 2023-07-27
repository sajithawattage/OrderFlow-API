using Microsoft.AspNetCore.Mvc;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Controllers
{
    [JwtAuthorize]
    [Route("api")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly ISalesInvoiceService _salesInvoiceService;

        public InvoiceController(ISalesInvoiceService salesInvoiceService)
        {
            _salesInvoiceService = salesInvoiceService;
        }

        [HttpPost]
        [Route("invoice")]
        public IActionResult Post(InvoiceRequestViewModel invoices)
        {
            //validate invoice ViewModel

            _salesInvoiceService.AddInvoice(invoices);

            return Ok();
        }
    }
}
