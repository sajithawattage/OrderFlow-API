using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptDebtorsBalancePriceTemp1
{
    public DateTime? ReceiptDate { get; set; }

    public string? ItemCode { get; set; }

    public string? CustomerName { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? AreaCode { get; set; }

    public string? AreaName { get; set; }

    public string? Address { get; set; }

    public string? Status { get; set; }
}
