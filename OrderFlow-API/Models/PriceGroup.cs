using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PriceGroup
{
    public int? PriceCode { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Price { get; set; }
}
