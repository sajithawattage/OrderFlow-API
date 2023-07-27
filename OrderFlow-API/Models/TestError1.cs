using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class TestError1
{
    public int PetyCashNumber { get; set; }

    public decimal? ChequeAmount { get; set; }

    public decimal? AsTotalAmount { get; set; }
}
