using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class InvoiceHeaderOld
{
    public string? SystemCode { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public DateTime? InvoiceDate { get; set; }

    public DateTime? InvoiceTime { get; set; }

    public string? PaymentType { get; set; }

    public string? VatType { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Cheque { get; set; }

    public decimal? CreditCard { get; set; }

    public decimal? Credit { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? TotalCommission { get; set; }

    public int? NoOfItems { get; set; }

    public string? BillPrint { get; set; }

    public int? BillCopy { get; set; }

    public int? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? OrderNo { get; set; }

    public string? CustomerVatNo { get; set; }

    public string? CustomerVatName { get; set; }

    public string? CustomerVatAddress { get; set; }

    public string? Remarks { get; set; }

    public string? SoldBy { get; set; }

    public string? Dtype { get; set; }

    public string? UserId { get; set; }

    public int? CreditNo { get; set; }

    public decimal? CashReceived { get; set; }

    public decimal? AmountForCommission { get; set; }

    public decimal? CommissionPaid { get; set; }

    public int? RepCode { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? CommPer { get; set; }
}
