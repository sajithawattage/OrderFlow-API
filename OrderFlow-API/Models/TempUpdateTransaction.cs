using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TempUpdateTransaction
{
    public int VoucherNumber { get; set; }

    public int? SupplierCode { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? BookVoucherNo { get; set; }

    public string? Description { get; set; }

    public decimal? AmountPaid { get; set; }

    public string ChequeNo { get; set; } = null!;

    public DateTime? ChequeDate { get; set; }

    public decimal? ChequeAmount { get; set; }
}
