using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CustomerCreditControl
{
    public int ReceiptComputerCode { get; set; }

    public string VehicleCode { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string ReceiptsNo { get; set; } = null!;

    public decimal? CreditAmount { get; set; }

    public decimal? SettledAmount { get; set; }

    public int? CreditCode { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? Type { get; set; }

    public string? OldInvoice { get; set; }

    public string? BankCode { get; set; }
}
