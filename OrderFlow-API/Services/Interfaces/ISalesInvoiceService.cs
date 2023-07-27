using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Services.Interfaces
{
    public interface ISalesInvoiceService
    {
        public void AddInvoice(InvoiceRequestViewModel invoice);
    }
}
