using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TransferInDetail
{
    public int TransferInNumber { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? QuantityC { get; set; }

    public int? QuantityP { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? OrderNo { get; set; }
}
