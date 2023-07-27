using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class ChangeHistory
{
    public DateTime? ChangeDate { get; set; }

    public string? ItemCode { get; set; }

    public decimal? OldValue { get; set; }

    public decimal? NewValue { get; set; }

    public string? UserId { get; set; }
}
