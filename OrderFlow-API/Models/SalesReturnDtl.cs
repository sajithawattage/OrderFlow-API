using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class SalesReturnDtl
{
    public int Srnumber { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? ReturnedQuantity { get; set; }

    public decimal? UnitPrice { get; set; }
}
