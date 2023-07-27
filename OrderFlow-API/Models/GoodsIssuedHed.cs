using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class GoodsIssuedHed
{
    public int Ginumber { get; set; }

    public string VehicleCode { get; set; } = null!;

    public string? SlipNumber { get; set; }

    public DateTime? IssuedDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? IssuedType { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
