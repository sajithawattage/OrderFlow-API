using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PurchaseReturnDetail
{
    public int PurchaseReturnNumber { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? PurchaseReturnQuantityC { get; set; }

    public int? PurchaseReturnQuantityP { get; set; }

    public decimal? PurchaseReturnUnitPrice { get; set; }
}
