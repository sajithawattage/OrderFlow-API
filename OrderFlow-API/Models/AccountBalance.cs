using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class AccountBalance
{
    public string AccountCode { get; set; } = null!;

    public int? RYear { get; set; }

    public int? RMonth { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? DataDate { get; set; }
}
