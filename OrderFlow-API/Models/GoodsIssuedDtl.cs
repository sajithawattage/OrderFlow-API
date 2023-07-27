using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class GoodsIssuedDtl
{
    public int Ginumber { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? LoadQuantityCases { get; set; }

    public int? LoadQuantityPieces { get; set; }
}
