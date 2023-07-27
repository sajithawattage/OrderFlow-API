using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class InvoiceDetailsOld
{
    public string? SystemCode { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public int? ItemOrder { get; set; }

    public string ItemCode { get; set; } = null!;

    public int? QuantityC { get; set; }

    public int? QuantityP { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? SoldPrice { get; set; }

    public decimal? Discount { get; set; }

    public decimal? ReturnedC { get; set; }

    public decimal? ReturnedP { get; set; }

    public string? Description { get; set; }
}
