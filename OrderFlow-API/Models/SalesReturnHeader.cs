using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class SalesReturnHeader
{
    public int Srnumber { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? VehicleCode { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? Grnnumber { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? RepCode { get; set; }

    public string? Remarks { get; set; }

    public string? Rupees { get; set; }

    public string? CaccountCode { get; set; }

    public int? AccTransactionNo { get; set; }

    public string? AcceptedBy { get; set; }

    public string? OldInvoice { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
