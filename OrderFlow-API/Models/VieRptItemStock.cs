using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptItemStock
{
    public string ItemCode { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? PartNo { get; set; }

    public double? StockInHand { get; set; }

    public decimal? LastPurchasePrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public string? CompanyName { get; set; }

    public string? CategoryDescription { get; set; }

    public string? CategoryCode { get; set; }
}
