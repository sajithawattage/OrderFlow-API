using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Services.Interfaces
{
    public interface IChequeService
    {
        public List<ReturnChequeViewModel> GetReturnCheques();
    }
}
