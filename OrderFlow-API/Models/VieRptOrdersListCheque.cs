using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptOrdersListCheque
{
    public string? CustomerCode { get; set; }

    public decimal? Cheques { get; set; }

    public DateTime? ChequeDate { get; set; }

    public string? BankCode { get; set; }

    public string? ChequeNumber { get; set; }

    public string? BankName { get; set; }

    public string? ShortName { get; set; }

    public int? CsheetNo { get; set; }
}
