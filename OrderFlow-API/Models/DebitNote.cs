using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class DebitNote
{
    public string CustomerCode { get; set; } = null!;

    public DateTime? DebitDate { get; set; }

    public decimal? DebitAount { get; set; }

    public decimal? Setteld { get; set; }

    public string? Remarks { get; set; }
}
