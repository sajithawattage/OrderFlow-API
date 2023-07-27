using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class SpoAppDeptorsList
{
    public string? CustomerName { get; set; }

    public int InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public decimal? CreditAmount { get; set; }

    public decimal? SettledAmount { get; set; }

    public decimal? Balance { get; set; }

    public int? Days { get; set; }
}
