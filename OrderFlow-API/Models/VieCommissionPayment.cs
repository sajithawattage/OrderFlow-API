using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieCommissionPayment
{
    public int? ReceiptComputerCode { get; set; }

    public DateTime? DateFrom { get; set; }
}
