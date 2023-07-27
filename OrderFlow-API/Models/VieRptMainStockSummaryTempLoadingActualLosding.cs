using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptMainStockSummaryTempLoadingActualLosding
{
    public string ItemCode { get; set; } = null!;

    public int? LoadQty { get; set; }
}
