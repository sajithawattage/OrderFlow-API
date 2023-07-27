using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CreditNotesDetail
{
    public int? Cnnumber { get; set; }

    public int? ReceiptComputerCode { get; set; }

    public decimal? Amount { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? CreditCode { get; set; }
}
