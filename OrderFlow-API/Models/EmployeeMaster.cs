using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class EmployeeMaster
{
    public string? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeeLocation { get; set; }

    public DateTime? EntryDate { get; set; }
}
