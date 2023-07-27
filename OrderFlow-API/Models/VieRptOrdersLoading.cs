using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptOrdersLoading
{
    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public int? QuantityRequired { get; set; }
}
