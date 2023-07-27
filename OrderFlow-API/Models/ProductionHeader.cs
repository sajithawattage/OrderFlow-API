using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ProductionHeader
{
    public int ProductionNumber { get; set; }

    public string? EmployeeCode { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? ProductDate { get; set; }

    public string? Remarks { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? UserId { get; set; }
}
