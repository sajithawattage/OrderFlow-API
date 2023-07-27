using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class VieDisInvoiceNunIssued
{
    public int ReceiptComputerCode { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public string? VehicleCode { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? NoOfItems { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }
}
