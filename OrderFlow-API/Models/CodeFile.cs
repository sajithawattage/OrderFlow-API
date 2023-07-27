using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CodeFile
{
    public int? InvoiceNumber { get; set; }

    public string? ItemCode { get; set; }

    public int? LoadNumber { get; set; }

    public int? ReceiptsCode { get; set; }

    public int? DamageCode { get; set; }

    public int? OrderNo { get; set; }

    public int? CsheetNo { get; set; }

    public int? Srnumber { get; set; }

    public int? Cnnumber { get; set; }

    public int? Ginumber { get; set; }

    public int? Jenumber { get; set; }
}
