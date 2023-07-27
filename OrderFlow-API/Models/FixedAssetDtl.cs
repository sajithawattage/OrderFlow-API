using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class FixedAssetDtl
{
    public int FixedAssetNumber { get; set; }

    public int DepreceationCode { get; set; }

    public decimal? DepreciationAmount { get; set; }
}
