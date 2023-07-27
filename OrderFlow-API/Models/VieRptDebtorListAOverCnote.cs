using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptDebtorListAOverCnote
{
    public int? ReceiptComputerCode { get; set; }

    public string? CustomerCode { get; set; }

    public decimal? OverCnoteAmount { get; set; }

    public int? CreditCode { get; set; }
}
