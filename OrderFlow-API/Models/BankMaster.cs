using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class BankMaster
{
    public string BankCode { get; set; } = null!;

    public string? BankName { get; set; }

    public string? ShortName { get; set; }
}
