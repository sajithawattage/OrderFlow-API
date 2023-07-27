using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TempStockCard
{
    public DateTime? InvoiceDate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? Des { get; set; }

    public int? QtyC { get; set; }

    public string? Type { get; set; }

    public int? BalanceC { get; set; }

    public string? ItemCode { get; set; }
}
