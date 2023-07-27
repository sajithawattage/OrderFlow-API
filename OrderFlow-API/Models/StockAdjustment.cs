using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class StockAdjustment
{
    public int? AdjustmentNo { get; set; }

    public DateTime? AdjustmentDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? StockInC { get; set; }

    public int? StockInP { get; set; }

    public decimal? AvaragePurchasePrice { get; set; }

    public decimal? LastPurchasePrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? WholesalePrice { get; set; }

    public decimal? SpecialPrice { get; set; }

    public int? NewStockInC { get; set; }

    public int? NewStockInP { get; set; }

    public decimal? NewAvaragePurchasePrice { get; set; }

    public decimal? NewLastPurchasePrice { get; set; }

    public decimal? NewRetailPrice { get; set; }

    public decimal? NewWholesalePrice { get; set; }

    public decimal? NewSpecialPrice { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
