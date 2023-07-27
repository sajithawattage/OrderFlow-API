using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TempPettyCashBook
{
    public int? PetyCashNumber { get; set; }

    public int? TransactionNo { get; set; }

    public string? AccountCode { get; set; }

    public decimal? ChequeAmount { get; set; }

    public DateTime? ChequeDate { get; set; }

    public string? ChequeNo { get; set; }

    public string? Description { get; set; }

    public decimal? Amount { get; set; }

    public string? AccName { get; set; }

    public DateTime? InvoiceDate { get; set; }
}
