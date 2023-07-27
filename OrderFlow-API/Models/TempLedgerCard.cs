using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TempLedgerCard
{
    public string CustomerCode { get; set; } = null!;

    public int? RYear { get; set; }

    public int? RMonth { get; set; }

    public decimal? Balance { get; set; }

    public string? Category { get; set; }

    public DateTime? DataDate { get; set; }

    public DateTime? RDate { get; set; }

    public string? RefNo { get; set; }

    public string? Details { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }
}
