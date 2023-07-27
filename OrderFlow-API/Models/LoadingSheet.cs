using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class LoadingSheet
{
    public int LoadNumber { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? ItemCode { get; set; }

    public int? OrderNo { get; set; }

    public int? QuantityRequired { get; set; }

    public string? Colour { get; set; }

    public DateTime? LoadDate { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
