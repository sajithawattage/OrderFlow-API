using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CollectionSheetDtl
{
    public int? CsheetNo { get; set; }

    public int? SerialNo { get; set; }

    public string? Trnumber { get; set; }

    public int? ReceiptComputerCode { get; set; }

    public string? BillNo { get; set; }

    public string? CustomerCode { get; set; }

    public decimal? PaiedAmount { get; set; }

    public decimal? TotalCash { get; set; }

    public decimal? TotalCheque { get; set; }

    public int? CreditCode { get; set; }
}
