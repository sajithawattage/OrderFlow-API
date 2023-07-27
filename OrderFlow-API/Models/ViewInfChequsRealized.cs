using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ViewInfChequsRealized
{
    public DateTime? ChequeDate { get; set; }

    public string? ChequeNumber { get; set; }

    public decimal? ChequeAmount { get; set; }

    public string? BankName { get; set; }

    public string? CustomerName { get; set; }

    public string? ChequeStatus { get; set; }

    public int? CsheetNo { get; set; }

    public DateTime? DisBerDate { get; set; }

    public string? CustomerCode { get; set; }
}
