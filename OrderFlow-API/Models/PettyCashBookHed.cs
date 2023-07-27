using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class PettyCashBookHed
{
    public int PetyCashNumber { get; set; }

    public string? ChequeNo { get; set; }

    public string? Description { get; set; }

    public DateTime? ChequeDate { get; set; }

    public decimal? ChequeAmount { get; set; }

    public string? Remarks { get; set; }

    public int? AccTransactionNo { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
