using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class OrderDtl
{
    public int OrderNo { get; set; }

    public string? ItemCode { get; set; }

    public int? Quantity { get; set; }

    public int? QuantityIssued { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Price { get; set; }

    public int? ItemOrder { get; set; }

    public string? ColourDes { get; set; }
}
