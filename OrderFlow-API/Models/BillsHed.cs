using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class BillsHed
{
    public int BillNumber { get; set; }

    public int? SupplierCode { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? RefNo { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? EntryTime { get; set; }

    public decimal? TotalDiscount { get; set; }

    public int? SystemType { get; set; }

    public string? Description { get; set; }

    public DateTime? SystemDate { get; set; }

    public int? Grnnumber { get; set; }
}
