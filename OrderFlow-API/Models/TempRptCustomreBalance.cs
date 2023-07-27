using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TempRptCustomreBalance
{
    public string? CustomerCode { get; set; }

    public decimal? A30 { get; set; }

    public decimal? A60 { get; set; }

    public decimal? A90 { get; set; }

    public decimal? Av90 { get; set; }

    public string? Type { get; set; }
}
