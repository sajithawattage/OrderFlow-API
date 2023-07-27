using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieStockCardLoad
{
    public DateTime? LoadDate { get; set; }

    public int LoadNumber { get; set; }

    public string Expr1 { get; set; } = null!;

    public int? LoadQuantityCases { get; set; }

    public string Expr2 { get; set; } = null!;

    public int Expr3 { get; set; }
}
