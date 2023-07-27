namespace OrderFlow.Api.ViewModels
{
    public class ReturnChequeViewModel
    {
        public string CustomerName { get; set; }
        public string Details { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public string BankName { get; set; }
        public int ReceiptComputerCode { get; set;}
    }

    public class ReturnChequeResponse : BaseResponse
    {
        public List<ReturnChequeViewModel> body { get; set; }

    }
}
