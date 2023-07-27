using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptMainStockSummaryTempBf
{
    public string ItemCode { get; set; } = null!;

    public int? BfstockInCases { get; set; }
}
