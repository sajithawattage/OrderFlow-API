using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TempDataView
{
    public string AccountCodeFrom { get; set; } = null!;

    public string AccountCodeTo { get; set; } = null!;

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public int? CodeFrom { get; set; }

    public int? CodeTo { get; set; }

    public string? ChrCodeFrom { get; set; }

    public string? ChrCodeTo { get; set; }

    public string? ItemCode { get; set; }

    public int? ReceiptComputerCode { get; set; }

    public string? AreaCode { get; set; }

    public DateTime? DayEndDate { get; set; }

    public int? RepCode { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? CustomerCode { get; set; }
}
