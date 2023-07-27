using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptCreditPayment
{
    public int ReceiptComputerCode { get; set; }

    public string ReceiptsNo { get; set; } = null!;

    public decimal? CreditAmount { get; set; }

    public decimal? SettledAmount { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? CustomerName { get; set; }

    public string CustomerCode { get; set; } = null!;
}
