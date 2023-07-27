using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class InvoiceDetail
{
    public int ReceiptComputerCode { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? Quantity { get; set; }

    public int? QuantityFree { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Price { get; set; }

    public int? ItemOrder { get; set; }

    public string? ColourDes { get; set; }

    public int? ReturnQty { get; set; }

    public decimal? DisPer { get; set; }

    public decimal? Amount { get; set; }

    public decimal? CostPrice { get; set; }
}
