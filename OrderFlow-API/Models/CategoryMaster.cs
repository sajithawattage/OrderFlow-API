using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CategoryMaster
{
    public string CategoryCode { get; set; } = null!;

    public string? CategoryDescription { get; set; }

    public DateTime? EntryDate { get; set; }
}
