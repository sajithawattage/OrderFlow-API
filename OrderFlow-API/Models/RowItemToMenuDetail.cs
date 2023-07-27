using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class RowItemToMenuDetail
{
    public string ItemCodeMenu { get; set; } = null!;

    public string ItemCodeRow { get; set; } = null!;

    public double? Qty { get; set; }
}
