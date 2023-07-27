using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class DamegeItemHeader
{
    public int? DamegeNumber { get; set; }

    public int? ReturnDamegeNumber { get; set; }

    public string OutlatCode { get; set; } = null!;

    public DateTime? DateOfReturn { get; set; }

    public DateTime? DateOfReceived { get; set; }

    public int? NoOfItems { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Remarks { get; set; }

    public string? ReturnUser { get; set; }

    public string? AcceptedUser { get; set; }

    public string? EntryType { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
