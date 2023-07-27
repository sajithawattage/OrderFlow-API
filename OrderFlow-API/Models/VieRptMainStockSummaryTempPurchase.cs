using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptMainStockSummaryTempPurchase
{
    public string? ItemCode { get; set; }

    public double? PurchaseQty { get; set; }
}
