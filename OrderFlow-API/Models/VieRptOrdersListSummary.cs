using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptOrdersListSummary
{
    public string? ItemCode { get; set; }

    public string? ItemDescription { get; set; }

    public int? AstotalQty { get; set; }
}
