using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptPaymentVoucherBill
{
    public int VoucherNumber { get; set; }

    public string? SupplierName { get; set; }

    public string? Address { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? BillDate { get; set; }

    public string? Description { get; set; }

    public decimal? AmountPaid { get; set; }
}
