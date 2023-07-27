using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptOrdersListCredit
{
    public string? CustomerCode { get; set; }

    public decimal Balanced { get; set; }
}
