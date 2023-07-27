using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptPaymentCashBook
{
    public int AccTransactionNo { get; set; }

    public int? TransactionNo { get; set; }

    public string? AccountCode { get; set; }

    public DateTime? TrDate { get; set; }

    public string? ChequeNo { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public string? AccName { get; set; }

    public string? Supplier { get; set; }

    public string? AccCode { get; set; }

    public int AccountOrder { get; set; }
}
