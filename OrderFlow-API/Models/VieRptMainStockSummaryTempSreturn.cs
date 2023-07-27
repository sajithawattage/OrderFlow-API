using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptMainStockSummaryTempSreturn
{
    public string ItemCode { get; set; } = null!;

    public int? Returned { get; set; }
}
