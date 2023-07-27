using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptDebtorListAOverCollection
{
    public int? ReceiptComputerCode { get; set; }

    public string? CustomerCode { get; set; }

    public decimal? OverPaiedAmount { get; set; }

    public int? CreditCode { get; set; }
}
