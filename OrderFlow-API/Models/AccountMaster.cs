using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class AccountMaster
{
    public string AccountCode { get; set; } = null!;

    public int? TypeCode { get; set; }

    public string? AccountName { get; set; }

    public string? MainAccountCode { get; set; }

    public string? Remarks { get; set; }

    public decimal? OpeningBalance { get; set; }

    public DateTime? BalancetoDate { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? AccountOrder { get; set; }

    public int? SubTypeCode { get; set; }
}
