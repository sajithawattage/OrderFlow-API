using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CompanyMaster
{
    public string? SystemCode { get; set; }

    public string? SystemName { get; set; }

    public string? SystemType { get; set; }

    public string? InvoiceNoD1 { get; set; }

    public string? InvoiceNoD2 { get; set; }

    public string? InvoiceNoCv { get; set; }

    public string? InvoiceNoCn { get; set; }

    public string? InvoiceNoRv { get; set; }

    public string? InvoiceNoRn { get; set; }

    public int? Grnnumber { get; set; }

    public int? PurchaseReturnNumber { get; set; }

    public int? SalesReturnNumber { get; set; }
}
