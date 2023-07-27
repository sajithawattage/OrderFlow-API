using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class SalesRepMaster
{
    public int RepCode { get; set; }

    public string? RepName { get; set; }

    public string? RepAddress { get; set; }

    public string? RepTelMobile { get; set; }

    public string? RepTelResident { get; set; }

    public string? RepAvtive { get; set; }

    public DateTime? RepLastLoginDate { get; set; }

    public string? AreaCode { get; set; }
}
