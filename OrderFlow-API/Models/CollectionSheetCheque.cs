using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CollectionSheetCheque
{
    public int? CsheetNo { get; set; }

    public string? CustomerCode { get; set; }

    public string? BankCode { get; set; }

    public string? ChequeNumber { get; set; }

    public int? ReceiptComputerCode { get; set; }

    public int? CreditCode { get; set; }

    public decimal? PaiedAmount { get; set; }
}
