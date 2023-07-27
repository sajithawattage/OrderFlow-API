using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptOrdersLoadingCustomer
{
    public string? ItemDescription { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? Address { get; set; }

    public int OrderNo { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? ItemCode { get; set; }

    public int? QuantityRequired { get; set; }

    public string? ColourDes { get; set; }

    public int? ItemOrder { get; set; }

    public int? LoadNumber { get; set; }
}
