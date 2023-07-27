using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class LoginHistory
{
    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public DateTime? InDate { get; set; }

    public DateTime? InTime { get; set; }

    public DateTime? OutDate { get; set; }

    public DateTime? OutTime { get; set; }

    public string? ProgramType { get; set; }

    public string? Login { get; set; }
}
