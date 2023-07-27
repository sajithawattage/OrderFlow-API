using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class XJournalEntryHed
{
    public int JournalEntryNumber { get; set; }

    public DateTime? Jedate { get; set; }

    public decimal? Jeamount { get; set; }

    public string? Description { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
