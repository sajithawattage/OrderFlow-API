using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptLedgerCard
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

    public string? CustomerName { get; set; }

    public string? Address { get; set; }

    public decimal? Expr1 { get; set; }

    public decimal? Expr2 { get; set; }

    public string Expr3 { get; set; } = null!;
}
