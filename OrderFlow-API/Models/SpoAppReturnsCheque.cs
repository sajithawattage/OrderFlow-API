using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class SpoAppReturnsCheque
{
    public string? CustomerName { get; set; }

    public string Details { get; set; } = null!;

    public DateTime? Date { get; set; }

    public decimal? Amount { get; set; }

    public int? RepCode { get; set; }

    public string? BankName { get; set; }
}
