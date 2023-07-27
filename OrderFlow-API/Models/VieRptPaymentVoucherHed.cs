using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptPaymentVoucherHed
{
    public int VoucherNumber { get; set; }

    public string? SupplierName { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? BookVoucherNo { get; set; }

    public string? Email { get; set; }
}
