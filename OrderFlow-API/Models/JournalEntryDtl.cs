using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class JournalEntryDtl
{
    public int JournalEntryNumber { get; set; }

    public string AccountCode { get; set; } = null!;

    public string? CorD { get; set; }

    public decimal? Amount { get; set; }

    public string? Reftype { get; set; }
}
