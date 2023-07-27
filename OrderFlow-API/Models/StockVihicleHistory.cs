using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class StockVihicleHistory
{
    public DateTime? LastLogingDate { get; set; }

    public string? VehicleCode { get; set; }

    public string? ItemCode { get; set; }

    public int? StockInCases { get; set; }

    public int? StockInPieces { get; set; }
}
