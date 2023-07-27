using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ProductionDetail
{
    public int ProductionNumber { get; set; }

    public string ItemCode { get; set; } = null!;

    public double? QuantityMaked { get; set; }

    public decimal? Price { get; set; }

    public int? OrderNo { get; set; }

    public double? ReturnQty { get; set; }
}
