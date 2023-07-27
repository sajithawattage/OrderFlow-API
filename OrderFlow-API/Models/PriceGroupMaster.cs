using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PriceGroupMaster
{
    public int? PriceCode { get; set; }

    public string? PriceDescription { get; set; }
}
