using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieStockCardGrn
{
    public DateTime? SystemDate { get; set; }

    public int BillNumber { get; set; }

    public string Expr1 { get; set; } = null!;

    public double? PurchasedQuantity { get; set; }

    public string Expr3 { get; set; } = null!;

    public int Expr2 { get; set; }
}
