using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieDataViewJournalEntry
{
    public int JournalEntryNumber { get; set; }

    public DateTime? Jedate { get; set; }

    public decimal? Jeamount { get; set; }

    public string? Description { get; set; }
}
