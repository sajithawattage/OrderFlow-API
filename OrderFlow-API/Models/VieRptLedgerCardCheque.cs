using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptLedgerCardCheque
{
    public DateTime? CollectedDate { get; set; }

    public string? ChequeNumber { get; set; }

    public DateTime? ChequeDate { get; set; }

    public decimal? ChequeAmount { get; set; }

    public string? ChequeStatus { get; set; }

    public string? BookNumber { get; set; }

    public string? BankCode { get; set; }

    public string? BankName { get; set; }

    public string? CustomerCode { get; set; }
}
