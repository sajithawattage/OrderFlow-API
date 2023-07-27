using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieDisInvoiceLoading
{
    public string? VehicleCode { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public int? Quantity { get; set; }
}
