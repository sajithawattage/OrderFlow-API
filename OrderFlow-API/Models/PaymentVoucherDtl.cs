using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PaymentVoucherDtl
{
    public int VoucherNumber { get; set; }

    public int BillNumber { get; set; }

    public decimal? AmountPaid { get; set; }
}
