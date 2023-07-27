using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PurchaseReturnx
{
    public int? PurchaseReturnCode { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? ItemCode { get; set; }

    public int? QtyC { get; set; }

    public int? QtyP { get; set; }
}
