using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieRptOrdersList
{
    public string? CustomerName { get; set; }

    public decimal Balance { get; set; }

    public decimal? A30 { get; set; }

    public decimal? A60 { get; set; }

    public decimal? A90 { get; set; }

    public decimal? Av90 { get; set; }

    public string? AreaName { get; set; }

    public string? Address { get; set; }

    public string? Tel { get; set; }

    public DateTime? ChequeDate { get; set; }

    public string? ChequeNumber { get; set; }

    public string? ShortName { get; set; }

    public decimal? Cheques { get; set; }

    public string? ContactName { get; set; }

    public string? Fax { get; set; }

    public string? CustomerCode { get; set; }

    public string Expr1 { get; set; } = null!;

    public string? Type { get; set; }
}
