using OrderFlow.Api.Models;
using OrderFlow.Api.Services.Interfaces;
using OrderFlow.Api.ViewModels;

namespace OrderFlow.Api.Services
{
    public class SalesInvoiceService : ISalesInvoiceService
    {
        private readonly SeefaErpceytramContext erpceytramContext;

        public SalesInvoiceService(SeefaErpceytramContext erpceytramContext)
        {
            this.erpceytramContext = erpceytramContext;
        }

        public void AddInvoice(InvoiceRequestViewModel invoice)
        {
            var transaction = erpceytramContext.Database.BeginTransaction();
            try
            {
                erpceytramContext.InvoiceHeaders.Add(new InvoiceHeader
                {
                    ReceiptComputerCode = invoice.InvoiceHeader.ReceiptComputerCode,
                    CustomerCode = invoice.InvoiceHeader.CustomerCode,
                    VehicleCode = invoice.InvoiceHeader.VehicleCode,
                    ReceiptDate = DateTime.Now,
                    SystemDate = DateTime.Now,
                    ReceiptsNo = invoice.InvoiceHeader.ReceiptComputerCode.ToString(),
                    TotalAmount = invoice.InvoiceHeader.TotalAmount,
                    TotalDiscount = 0,
                    BillAmount = 0,
                    VatAmount = 0,
                    Nbtamount = 0,
                    Cash = 0,
                    Cheque = 0,
                    Credit = 0,
                    Adpay = 0,
                    NoOfItems = invoice.InvoiceHeader.NoOfItems,
                    VatNo = string.Empty,
                    SvatNo = string.Empty,
                    Pono = string.Empty,
                    Remarks = string.Empty,
                    BillType = "R",
                    RepCode = invoice.InvoiceHeader.RepCode,
                    Status = "I",
                    UserId = invoice.InvoiceHeader.UserId,
                    EntryDate = DateTime.Now,
                    StockUpdateDate = DateTime.Now,
                });

                erpceytramContext.SaveChanges();

                foreach (var invoiceLine in invoice.InvoiceHeader.InvoiceLines)
                {
                    erpceytramContext.InvoiceDetails.Add(new InvoiceDetail
                    {
                        ReceiptComputerCode = invoice.InvoiceHeader.ReceiptComputerCode,
                        ItemCode = invoiceLine.ItemCode,
                        Quantity = invoiceLine.Quantity,
                        QuantityFree = invoiceLine.QuantityFree,
                        Discount = 0,
                        Price = invoiceLine.Price,
                        ItemOrder = invoiceLine.ItemOrder,
                        ColourDes = string.Empty,
                        ReturnQty = 0,
                        DisPer = 0,
                        Amount = 0,
                        CostPrice = invoiceLine.CostPrice
                    });
                }

                erpceytramContext.SaveChanges();

                erpceytramContext.SalesReturnHeaders.Add(new SalesReturnHeader
                {
                    Srnumber = invoice.SalesReturnHeader.SRNumber,
                    CustomerCode = invoice.SalesReturnHeader.CustomerCode,
                    VehicleCode = invoice.SalesReturnHeader.VehicleCode,
                    ReturnDate = invoice.SalesReturnHeader.ReturnDate,
                    Grnnumber = invoice.SalesReturnHeader.GrnNumber,
                    TotalAmount = invoice.SalesReturnHeader.TotalAmount,
                    RepCode = invoice.SalesReturnHeader.RepCode,
                    Remarks = string.Empty,
                    Rupees = string.Empty,
                    CaccountCode = string.Empty,
                    AccTransactionNo = -1,
                    AcceptedBy = string.Empty,
                    OldInvoice = "A",
                    UserId = invoice.SalesReturnHeader.UserId,
                    EntryDate = DateTime.Now
                });

                erpceytramContext.SaveChanges();

                foreach (var salesReturnLine in invoice.SalesReturnHeader.SalesReturnLines)
                {
                    erpceytramContext.SalesReturnDtls.Add(new SalesReturnDtl
                    {
                        Srnumber = invoice.SalesReturnHeader.SRNumber,
                        ItemCode = salesReturnLine.ItemCode,
                        ReturnedQuantity = salesReturnLine.ReturnedQuantity,
                        UnitPrice = salesReturnLine.UnitPrice
                    });
                }

                erpceytramContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }

        }
    }
}
