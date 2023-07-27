using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class UsersHega
{
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? UserLevel { get; set; }
}
