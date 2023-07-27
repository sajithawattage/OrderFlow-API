using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TransferInHeader
{
    public int? TransferInNumber { get; set; }

    public int? ReturnTransferNumber { get; set; }

    public string? LocationCode { get; set; }

    public DateTime? DateOfTransfer { get; set; }

    public DateTime? DateOfReceived { get; set; }

    public int? NoOfItems { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Remarks { get; set; }

    public string? ReturnUser { get; set; }

    public string? AcceptedUser { get; set; }

    public string? EntryType { get; set; }

    public bool? Accepted { get; set; }

    public string? UserId { get; set; }

    public DateTime? Entrydate { get; set; }
}
