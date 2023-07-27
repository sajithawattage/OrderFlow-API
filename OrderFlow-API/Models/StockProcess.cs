using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class StockProcess
{
    public string? VehicleCode { get; set; }

    public DateTime? ProcessDate { get; set; }

    public decimal? BillAmount { get; set; }
}
