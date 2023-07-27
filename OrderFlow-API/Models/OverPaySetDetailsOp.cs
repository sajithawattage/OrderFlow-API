using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class OverPaySetDetailsOp
{
    public int? Opsumber { get; set; }

    public int? Opnumber { get; set; }

    public decimal? Amount { get; set; }
}
