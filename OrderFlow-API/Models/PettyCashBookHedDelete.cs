using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PettyCashBookHedDelete
{
    public int? PetyCashNumber { get; set; }

    public DateTime? DeleteDate { get; set; }

    public string? Reason { get; set; }
}
