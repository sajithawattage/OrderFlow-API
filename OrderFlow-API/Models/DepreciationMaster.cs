using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class DepreciationMaster
{
    public int DepreceationCode { get; set; }

    public string? Description { get; set; }

    public string? ReduseMethord { get; set; }
}
