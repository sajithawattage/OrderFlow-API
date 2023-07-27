namespace OrderFlow.Api.ViewModels
{
    public class InvoiceRequestViewModel
    {
        public InvoiceHeaderViewModel InvoiceHeader { get; set; }
        public SalesReturnHeaderViewModel SalesReturnHeader { get; set; }
    }

    public class InvoiceHeaderViewModel
    {
        public int ReceiptComputerCode { get; set; }
        public string CustomerCode { get; set; }
        public string VehicleCode { get; set; }
        public DateTime ReceiptDate { get; set; }
        public DateTime SystemDate { get; set; }
        public string ReceiptsNo { get; set; }
        public decimal TotalAmount { get; set; }
        public int NoOfItems { get; set; }
        public int RepCode { get; set; }
        public string UserId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime StockUpdateDate { get; set; }
        public List<InvoiceLineViewModel> InvoiceLines { get; set; }
    }

    public class InvoiceLineViewModel
    {
        public string ReceiptComputerCode { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public int QuantityFree { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public int ItemOrder { get; set; }
        public string ColourDes { get; set; }
        public int ReturnQty { get; set; }
        public decimal DisPer { get; set; }
        public decimal Amount { get; set; }
        public decimal CostPrice { get; set; }
    }

    public class SalesReturnHeaderViewModel
    {
        public int SRNumber { get; set; }
        public string CustomerCode { get; set; }
        public string VehicleCode { get; set; }
        public DateTime ReturnDate { get; set; }
        public string GrnNumber { get; set; }
        public decimal TotalAmount { get; set; }
        public int RepCode { get; set; }
        public string UserId { get; set; }
        public List<SalesReturnLineViewModel> SalesReturnLines { get; set; }
    }

    public class SalesReturnLineViewModel
    {
        public string SRNumber { get; set; }
        public string ItemCode { get; set; }
        public int ReturnedQuantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class InvoiceResultViewModel
    {
        public string Status { get; set; }
        public int InvoiceNo { get; set; }
    }
}
