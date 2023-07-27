using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptTrnsPayment
{
    public int VoucherNumber { get; set; }

    public int? AccTransactionNo { get; set; }

    public int? SupplierCode { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? BookVoucherNo { get; set; }

    public string? Description { get; set; }

    public decimal? AmountPaid { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? Expr1 { get; set; }

    public DateTime? Expr2 { get; set; }

    public DateTime? Expr3 { get; set; }
}
