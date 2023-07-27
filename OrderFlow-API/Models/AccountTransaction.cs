using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class AccountTransaction
{
    public int AccTransactionNo { get; set; }

    public int TransactionNo { get; set; }

    public string AccountCode { get; set; } = null!;

    public DateTime? TrDate { get; set; }

    public decimal? Amount { get; set; }

    public string? DorC { get; set; }

    public string? ReferanceNo { get; set; }

    public string? Refype { get; set; }

    public string? TrDescription { get; set; }
}
