using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CustomerOrderHeader2
{
    public int RequestNo { get; set; }

    public string CustomerCode { get; set; } = null!;

    public int RepCode { get; set; }

    public string? RequestDate { get; set; }

    public string? RequestTime { get; set; }

    public string? SystemDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? Adpay { get; set; }

    public int? NoOfItems { get; set; }

    public string? Remarks { get; set; }

    public string? OrderStatus { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? RepPono { get; set; }

    public DateTime? RepPodate { get; set; }
}
