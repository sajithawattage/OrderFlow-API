using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class CustomerMaster
{
    public string CustomerCode { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? Address { get; set; }

    public string? Tel { get; set; }

    public string? VatNo { get; set; }

    public int? RepCode { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? ContactName { get; set; }

    public string? Fax { get; set; }

    public int? PriceCode { get; set; }

    public string? Others { get; set; }

    public string? Active { get; set; }

    public string? AreaCode { get; set; }

    public string? SvatNo { get; set; }

    public string? Email { get; set; }

    public string? NicNo { get; set; }

    public string? Image { get; set; }

    public decimal? CreditLimit { get; set; }
}
