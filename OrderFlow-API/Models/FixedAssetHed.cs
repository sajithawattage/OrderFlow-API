using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class FixedAssetHed
{
    public int? BillNumber { get; set; }

    public int FixedAssetNumber { get; set; }

    public string? FabookNo { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public string? Depreciation { get; set; }

    public decimal? Amount { get; set; }

    public decimal? NowValue { get; set; }

    public decimal? DepriciationValue { get; set; }

    public string? Remarks { get; set; }
}
