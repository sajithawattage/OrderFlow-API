using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class DamegeitemDetail
{
    public int? DamegeNumber { get; set; }

    public string? ItemCode { get; set; }

    public double? DamegeQuantityC { get; set; }

    public double? DamegeQuantityP { get; set; }

    public decimal? UnitPrice { get; set; }
}
