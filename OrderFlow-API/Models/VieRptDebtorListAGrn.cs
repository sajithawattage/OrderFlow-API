using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptDebtorListAGrn
{
    public int? ReceiptComputerCode { get; set; }

    public decimal? Grnamount { get; set; }

    public int? CreditCode { get; set; }
}
