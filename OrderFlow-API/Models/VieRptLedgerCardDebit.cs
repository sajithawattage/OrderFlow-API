using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptLedgerCardDebit
{
    public decimal? Setteld { get; set; }

    public decimal? DebitAount { get; set; }

    public DateTime? DebitDate { get; set; }
}
