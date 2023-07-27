using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ItemMasterxx
{
    public string? SysCode { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemDescription { get; set; }

    public string? PartNo { get; set; }

    public int? ReorderQuantity { get; set; }

    public string? OrderQty { get; set; }

    public string? RackNo { get; set; }

    public int? MeasureCode { get; set; }

    public int? PiecesforPack { get; set; }

    public double? StockInHand { get; set; }

    public double? StockInPieces { get; set; }

    public double? StockInDamage { get; set; }

    public double? StockInReserved { get; set; }

    public double? StockInOrdered { get; set; }

    public decimal? LastPurchasePrice { get; set; }

    public decimal? AvaragePurchasePrice { get; set; }

    public decimal? WholesalePrice { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? SpecialPrice { get; set; }

    public int? ItemOrder { get; set; }

    public string? CategoryCode { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? StockLocation { get; set; }

    public int? DiscountGroup { get; set; }

    public string? PartCode { get; set; }

    public string? PrintDescription { get; set; }

    public int? MaximumStock { get; set; }

    public string? Remarks { get; set; }

    public string? ActiveItem { get; set; }

    public string? ItemType { get; set; }

    public DateTime? LastPurchaseDate { get; set; }

    public DateTime? LastIssuesDate { get; set; }

    public decimal? LastIssuesPrice { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? LastUpdateDate { get; set; }

    public byte[]? ItemImage { get; set; }

    public int? ReorderLevel { get; set; }

    public string? Active { get; set; }

    public string? IncAccountCode { get; set; }

    public string? ColorActive { get; set; }
}
