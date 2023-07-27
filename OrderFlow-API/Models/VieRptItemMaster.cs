using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptItemMaster
{
    public string? CategoryDescription { get; set; }

    public string? CompanyName { get; set; }

    public string? SysCode { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? PartNo { get; set; }

    public int? ReorderQuantity { get; set; }

    public string? OrderQty { get; set; }

    public string? RackNo { get; set; }

    public int? MeasureCode { get; set; }

    public double? StockInHand { get; set; }

    public decimal? LastPurchasePrice { get; set; }

    public decimal? AvaragePurchasePrice { get; set; }

    public decimal? WholesalePrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? SpecialPrice { get; set; }

    public string? CategoryCode { get; set; }

    public string? ActiveItem { get; set; }

    public string? SystemName { get; set; }
}
