using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ProcessDetail
{
    public int? ProcessYear { get; set; }

    public int? ProcessMonth { get; set; }

    public string? MonthEndProcess { get; set; }

    public string? DebtorsProcess { get; set; }
}
