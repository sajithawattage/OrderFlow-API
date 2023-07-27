using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ItemTypeMaster
{
    public string? ItemTypeCode { get; set; }

    public string? ItemTypeDescription { get; set; }

    public DateTime? EntryDate { get; set; }
}
