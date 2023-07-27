using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class MeasureUnitMaster
{
    public int? MeasureCode { get; set; }

    public string? MainMesur { get; set; }

    public double? Qty { get; set; }
}
