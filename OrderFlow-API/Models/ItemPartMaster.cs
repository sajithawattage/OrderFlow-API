using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ItemPartMaster
{
    public string? PartCode { get; set; }

    public string? PartDescription { get; set; }

    public DateTime? EntryDate { get; set; }
}
