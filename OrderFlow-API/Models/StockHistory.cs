using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class StockHistory
{
    public DateTime? LastLogingDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? StockInCases { get; set; }

    public decimal? PurchaseCasePrice { get; set; }

    public decimal? WholesaleCasePrice { get; set; }

    public decimal? RetailPrice { get; set; }
}
