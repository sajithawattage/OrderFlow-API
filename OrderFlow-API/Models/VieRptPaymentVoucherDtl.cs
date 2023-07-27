using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptPaymentVoucherDtl
{
    public int VoucherNumber { get; set; }

    public string ChequeNo { get; set; } = null!;

    public DateTime? ChequeDate { get; set; }

    public decimal? ChequeAmount { get; set; }
}
