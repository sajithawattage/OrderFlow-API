using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class JournalEntryHed
{
    public int JournalEntryNumber { get; set; }

    public int? AccTransactionNo { get; set; }

    public DateTime? Jedate { get; set; }

    public decimal? Jeamount { get; set; }

    public string? BookNo { get; set; }

    public string? Description { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? Cnnumber { get; set; }
}
