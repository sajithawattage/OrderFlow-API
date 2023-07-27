using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class SupplierMaster
{
    public int SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Vat { get; set; }

    public string? SupplierType { get; set; }

    public string? ChequeTitle { get; set; }

    public string? AccountNumber { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }
}
