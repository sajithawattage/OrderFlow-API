using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CreditNote
{
    public int? Cnnumber { get; set; }

    public string? BookNumber { get; set; }

    public int? Srnumber { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? Cndate { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public decimal? OverPay { get; set; }

    public string? Userid { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? JournalEntryNumber { get; set; }
}
