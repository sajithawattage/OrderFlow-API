using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PurchaseReturnHeader
{
    public int PurchaseReturnNumber { get; set; }

    public int? Grnnumber { get; set; }

    public string? SupplierId { get; set; }

    public DateTime? ReturnDate { get; set; }

    public int? NoOfItems { get; set; }

    public decimal? TotalPurchasePrice { get; set; }

    public string? Returned { get; set; }

    public string? Approved { get; set; }

    public string? Collected { get; set; }

    public string? Remarks { get; set; }

    public string? EnteredUserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
