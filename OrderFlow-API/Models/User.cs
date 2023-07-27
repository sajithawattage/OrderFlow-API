using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? UserLevel { get; set; }

    public int? RepCode { get; set; }

    public string? AreaCode { get; set; }

    public bool? Active { get; set; }
}
