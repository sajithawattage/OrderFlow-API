using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PettyCashDtl
{
    public int PetyCashNumber { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Description { get; set; }

    public string? AccountCode { get; set; }

    public decimal? Amount { get; set; }

    public int? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
