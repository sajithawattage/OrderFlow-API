using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ChequeFileNx
{
    public int? CsheetNo { get; set; }

    public string? CustomerCode { get; set; }

    public string? BankCode { get; set; }

    public string? ChequeNumber { get; set; }

    public DateTime? ChequeDate { get; set; }

    public decimal? ChequeAmount { get; set; }

    public string? Type { get; set; }

    public string? ChequeStatus { get; set; }

    public DateTime? DisBerDate { get; set; }

    public string? AccountCode { get; set; }
}
