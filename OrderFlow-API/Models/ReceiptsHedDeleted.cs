using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ReceiptsHedDeleted
{
    public int? ReceiptNumber { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? BookReceiptNo { get; set; }

    public string? ReceiptDescription { get; set; }

    public decimal? ReceiptAmount { get; set; }

    public string? BankCode { get; set; }

    public string? ChequeNo { get; set; }

    public string? Remarks { get; set; }

    public string? DaccountCode { get; set; }

    public string? CaccountCode { get; set; }

    public int? AccTransactionNo { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
