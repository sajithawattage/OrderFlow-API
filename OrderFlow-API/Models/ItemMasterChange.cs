using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ItemMasterChange
{
    public string ItemCode { get; set; } = null!;

    public string? PrintDescription1 { get; set; }
}
