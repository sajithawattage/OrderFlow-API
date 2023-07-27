using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CollectionSheetHed
{
    public int? CsheetNo { get; set; }

    public int? CollectorCode { get; set; }

    public string? BookNumber { get; set; }

    public DateTime? CollectedDate { get; set; }

    public DateTime? SystemDate { get; set; }

    public decimal? TotalCash { get; set; }

    public decimal? TotalCheque { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
