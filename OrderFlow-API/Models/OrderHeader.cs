using System;
using System.Collections.Generic;

namespace OrderFlow.Api.Models;

public partial class OrderHeader
{
    public int OrderNo { get; set; }

    public string? CustomerCode { get; set; }

    public string? VehicleCode { get; set; }

    public DateTime? ReceiptDate { get; set; }

    public DateTime? SystemDate { get; set; }

    public string ReceiptsNo { get; set; } = null!;

    public decimal? TotalAmount { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? Nbtamount { get; set; }

    public decimal? Cash { get; set; }

    public decimal? Cheque { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Adpay { get; set; }

    public int? NoOfItems { get; set; }

    public string? VatNo { get; set; }

    public string? SvatNo { get; set; }

    public string? Pono { get; set; }

    public string? Remarks { get; set; }

    public string? BillType { get; set; }

    public int? RepCode { get; set; }

    public string? Status { get; set; }

    public string? UserId { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? OrderState { get; set; }
}
