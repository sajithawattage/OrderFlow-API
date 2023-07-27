using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class LoadHeader
{
    public int LoadNumber { get; set; }

    public string VehicleCode { get; set; } = null!;

    public string? SlipNumber { get; set; }

    public string? AreaCode { get; set; }

    public int? RepCode { get; set; }

    public DateTime? LoadDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? BillAmount { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? SystemDate { get; set; }
}
