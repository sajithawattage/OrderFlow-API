using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptTrialBalance
{
    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Amount { get; set; }

    public string? DorC { get; set; }
}
