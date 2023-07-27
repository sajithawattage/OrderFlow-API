using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieInfDayEnd
{
    public string? ItemCode { get; set; }

    public int? Quantity { get; set; }

    public string? VehicleCode { get; set; }
}
