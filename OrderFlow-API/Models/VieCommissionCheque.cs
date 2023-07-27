using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieCommissionCheque
{
    public int? ReceiptComputerCode { get; set; }

    public DateTime? DateFrom { get; set; }

    public int? CsheetNo { get; set; }

    public decimal? ChequeAmount { get; set; }

    public decimal? TotalAmount { get; set; }
}
