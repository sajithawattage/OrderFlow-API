using OrderFlow.Api.Models;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace OrderFlow.Api.Services
{
    public class ChequeService : IChequeService
    {
        private readonly SeefaErpceytramContext erpceytramContext;

        public ChequeService(SeefaErpceytramContext erpceytramContext)
        {
            this.erpceytramContext = erpceytramContext;
        }

        public List<ReturnChequeViewModel> GetReturnCheques()
        {
            return erpceytramContext.CustomerCreditControls
                        .GroupJoin(erpceytramContext.CustomerMasters,
                            creditControl => creditControl.CustomerCode,
                            customer => customer.CustomerCode,
                            (creditControl, customerGroup) => new { creditControl, customerGroup })
                        .SelectMany(
                            x => x.customerGroup.DefaultIfEmpty(),
                            (x, customer) => new { x.creditControl, customer })
                        .GroupJoin(erpceytramContext.BankMasters,
                            x => x.creditControl.BankCode,
                            bank => bank.BankCode,
                            (x, bankGroup) => new { x.creditControl, x.customer, bankGroup })
                        .SelectMany(
                            x => x.bankGroup.DefaultIfEmpty(),
                            (x, bank) => new ReturnChequeViewModel
                            {
                                CustomerName = x.customer.CustomerName,
                                Details = x.creditControl.ReceiptsNo,
                                Date = x.creditControl.ReceiptDate,
                                Amount = (x.creditControl.CreditAmount - x.creditControl.SettledAmount),
                                BankName = bank.BankName,
                                ReceiptComputerCode = x.creditControl.ReceiptComputerCode
                            })
                        .Where(x => x.Amount != 0 && x.ReceiptComputerCode != 0)
                        .OrderByDescending(x => x.Date).ToList();

        }
    }
}
