using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CompanyFile
{
    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CompanyTel { get; set; }

    public string? Vatactive { get; set; }

    public decimal? Vatper { get; set; }

    public string? Bttactive { get; set; }

    public decimal? Bttper { get; set; }

    public DateTime? LastLogingDate { get; set; }

    public string? GoodStart { get; set; }

    public DateTime? DayEnd { get; set; }

    public DateTime? LastLogingDateDaily { get; set; }

    public double? TargetPerSalesPerson { get; set; }
}
