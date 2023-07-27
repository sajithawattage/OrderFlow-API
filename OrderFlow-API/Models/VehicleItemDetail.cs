using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VehicleItemDetail
{
    public string ItemCode { get; set; } = null!;

    public string VehicleCode { get; set; } = null!;

    public int? StockInCases { get; set; }

    public int? StockInPieces { get; set; }

    public int? ReorderQuantity { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
