using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class XJournalEntryDtl
{
    public int JournalEntryNumber { get; set; }

    public string CustomerCode { get; set; } = null!;

    public int ReceiptComputerCode { get; set; }

    public string? CorD { get; set; }

    public decimal? Amount { get; set; }

    public string? Reftype { get; set; }
}
