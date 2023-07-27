using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptMainStockSummaryTempGoodsIssue
{
    public string ItemCode { get; set; } = null!;

    public int? GoodsIssue { get; set; }
}
