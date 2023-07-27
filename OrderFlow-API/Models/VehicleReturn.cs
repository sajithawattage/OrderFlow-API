using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VehicleReturn
{
    public string VehicleCode { get; set; } = null!;

    public DateTime? ReturnDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? StockInCases { get; set; }

    public int? StockInPieces { get; set; }

    public DateTime? EntryDate { get; set; }
}
