using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class GoodsTransferDtl
{
    public int? Gtnumber { get; set; }

    public string? ItemCode { get; set; }

    public int? Cases { get; set; }

    public int? Pieces { get; set; }
}
