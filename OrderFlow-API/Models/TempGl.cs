using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TempGl
{
    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public int? OrderNo { get; set; }

    public DateTime? Gldate { get; set; }

    public string? Description { get; set; }

    public string? RefDes { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }
}
