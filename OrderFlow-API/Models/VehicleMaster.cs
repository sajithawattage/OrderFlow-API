using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VehicleMaster
{
    public string VehicleCode { get; set; } = null!;

    public string? VehicleName { get; set; }

    public string? Root { get; set; }

    public DateTime? UnloadDate { get; set; }
}
