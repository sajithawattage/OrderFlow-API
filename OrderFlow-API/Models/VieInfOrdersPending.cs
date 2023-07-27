using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieInfOrdersPending
{
    public string? CustomerCode { get; set; }

    public string? ItemCode { get; set; }

    public int? Orders { get; set; }

    public string? ColourDes { get; set; }

    public int OrderNo { get; set; }

    public string? Pono { get; set; }
}
