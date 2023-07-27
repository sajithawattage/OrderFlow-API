using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ViewRptCustomerwiseSale
{
    public string? CustomerName { get; set; }

    public string? CustomerCode { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Cheque { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? CompanyName { get; set; }
}
