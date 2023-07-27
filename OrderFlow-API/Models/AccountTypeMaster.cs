using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class AccountTypeMaster
{
    public int TypeCode { get; set; }

    public string? TypeName { get; set; }
}
