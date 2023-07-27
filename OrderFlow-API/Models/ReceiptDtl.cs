using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ReceiptDtl
{
    public int ReceiptNumber { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public DateTime? InvoiceDate { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public decimal? DueAmount { get; set; }
}
