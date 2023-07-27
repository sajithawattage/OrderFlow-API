using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRecItemDetail
{
    public string? SysCode { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? PartNo { get; set; }

    public string? RackNo { get; set; }

    public double? StockInHand { get; set; }

    public decimal? LastPurchasePrice { get; set; }

    public decimal? AvaragePurchasePrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public string? CategoryCode { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? StockLocation { get; set; }

    public string? ActiveItem { get; set; }

    public DateTime? LastPurchaseDate { get; set; }

    public DateTime? LastIssuesDate { get; set; }
}
