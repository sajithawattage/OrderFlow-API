using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class Grndtl
{
    public int Grnnumber { get; set; }

    public string AccountCode { get; set; } = null!;

    public decimal? Amount { get; set; }

    public decimal AmountSettled { get; set; }

    public string? Remarks { get; set; }

    public string? ItemCode { get; set; }

    public double? PurchasedQuantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? ItemDiscount { get; set; }

    public int? ItemOrder { get; set; }

    public double? ReturnedC { get; set; }

    public string? ItemDescription { get; set; }
}
