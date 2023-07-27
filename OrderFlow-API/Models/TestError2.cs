using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TestError2
{
    public int PetyCashNumber { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChequeDate { get; set; }

    public decimal? ChequeAmount { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Description { get; set; }

    public string? AccountCode { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Def { get; set; }
}
