using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class GoodsTransferHed
{
    public int? Gtnumber { get; set; }

    public string? VehicleCodeFrom { get; set; }

    public string? VehicleCodeTo { get; set; }

    public DateTime? TransferDate { get; set; }

    public DateTime? SystemDate { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
