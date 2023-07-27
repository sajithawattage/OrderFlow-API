using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptMainStockSummaryTempStockIn
{
    public string ItemCode { get; set; } = null!;

    public int? StockIn { get; set; }
}
