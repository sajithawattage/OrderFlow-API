using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRecItemPriceDetail
{
    public int? PriceCode { get; set; }

    public string? PriceDescription { get; set; }

    public decimal? Price { get; set; }

    public string? ItemCode { get; set; }
}
