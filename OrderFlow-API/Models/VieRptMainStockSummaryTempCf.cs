using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptMainStockSummaryTempCf
{
    public string ItemCode { get; set; } = null!;

    public int? CfstockInCases { get; set; }

    public decimal? PurchaseCasePrice { get; set; }
}
