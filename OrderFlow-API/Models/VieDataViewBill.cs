using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieDataViewBill
{
    public int BillNumber { get; set; }

    public int? SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public string? Address { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? RefNo { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? PaidAmount { get; set; }
}
