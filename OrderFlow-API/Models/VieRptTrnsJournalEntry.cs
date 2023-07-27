using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptTrnsJournalEntry
{
    public int JournalEntryNumber { get; set; }

    public DateTime? Jedate { get; set; }

    public string? BookNo { get; set; }

    public string? Description { get; set; }

    public string AccountCode { get; set; } = null!;

    public string? CorD { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? AccountName { get; set; }
}
