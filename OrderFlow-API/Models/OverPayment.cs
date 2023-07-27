using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class OverPayment
{
    public int? Opnumber { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? Opdate { get; set; }

    public decimal? Opaount { get; set; }

    public decimal? Settled { get; set; }

    public string? Remarks { get; set; }
}
