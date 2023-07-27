using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OrderFlow.Api.Models;

public partial class SeefaErpceytramContext : DbContext
{
    public SeefaErpceytramContext(DbContextOptions<SeefaErpceytramContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ATestChequeTotal> ATestChequeTotals { get; set; }

    public virtual DbSet<AccountBalance> AccountBalances { get; set; }

    public virtual DbSet<AccountMaster> AccountMasters { get; set; }

    public virtual DbSet<AccountTransaction> AccountTransactions { get; set; }

    public virtual DbSet<AccountTypeMaster> AccountTypeMasters { get; set; }

    public virtual DbSet<AppNewRepSale> AppNewRepSales { get; set; }

    public virtual DbSet<AreaMaster> AreaMasters { get; set; }

    public virtual DbSet<BalanceHistory> BalanceHistories { get; set; }

    public virtual DbSet<BankMaster> BankMasters { get; set; }

    public virtual DbSet<BillsDtl> BillsDtls { get; set; }

    public virtual DbSet<BillsHed> BillsHeds { get; set; }

    public virtual DbSet<CategoryMaster> CategoryMasters { get; set; }

    public virtual DbSet<ChangeHistory> ChangeHistories { get; set; }

    public virtual DbSet<ChequeFile> ChequeFiles { get; set; }

    public virtual DbSet<ChequeFileNx> ChequeFileNxes { get; set; }

    public virtual DbSet<CodeFile> CodeFiles { get; set; }

    public virtual DbSet<CollectionSheetCheque> CollectionSheetCheques { get; set; }

    public virtual DbSet<CollectionSheetDtl> CollectionSheetDtls { get; set; }

    public virtual DbSet<CollectionSheetHed> CollectionSheetHeds { get; set; }

    public virtual DbSet<CollectorMaster> CollectorMasters { get; set; }

    public virtual DbSet<Colour> Colours { get; set; }

    public virtual DbSet<CompanyFile> CompanyFiles { get; set; }

    public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }

    public virtual DbSet<CreditNote> CreditNotes { get; set; }

    public virtual DbSet<CreditNotesDetail> CreditNotesDetails { get; set; }

    public virtual DbSet<CustomerCreditControl> CustomerCreditControls { get; set; }

    public virtual DbSet<CustomerCreditControlNx> CustomerCreditControlNxes { get; set; }

    public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }

    public virtual DbSet<CustomerMasterNew> CustomerMasterNews { get; set; }

    public virtual DbSet<CustomerOrderHeader2> CustomerOrderHeader2s { get; set; }

    public virtual DbSet<DamegeItemHeader> DamegeItemHeaders { get; set; }

    public virtual DbSet<DamegeitemDetail> DamegeitemDetails { get; set; }

    public virtual DbSet<DebitNote> DebitNotes { get; set; }

    public virtual DbSet<DebitNotesHed> DebitNotesHeds { get; set; }

    public virtual DbSet<DebtorsHed> DebtorsHeds { get; set; }

    public virtual DbSet<DepreciationMaster> DepreciationMasters { get; set; }

    public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }

    public virtual DbSet<FixedAssetDtl> FixedAssetDtls { get; set; }

    public virtual DbSet<FixedAssetHed> FixedAssetHeds { get; set; }

    public virtual DbSet<GoodsIssuedDtl> GoodsIssuedDtls { get; set; }

    public virtual DbSet<GoodsIssuedHed> GoodsIssuedHeds { get; set; }

    public virtual DbSet<GoodsTransferDtl> GoodsTransferDtls { get; set; }

    public virtual DbSet<GoodsTransferHed> GoodsTransferHeds { get; set; }

    public virtual DbSet<Grndtl> Grndtls { get; set; }

    public virtual DbSet<Grnhed> Grnheds { get; set; }

    public virtual DbSet<GroupMaster> GroupMasters { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<InvoiceDetailsOld> InvoiceDetailsOlds { get; set; }

    public virtual DbSet<InvoiceHeader> InvoiceHeaders { get; set; }

    public virtual DbSet<InvoiceHeaderOld> InvoiceHeaderOlds { get; set; }

    public virtual DbSet<ItemMaster> ItemMasters { get; set; }

    public virtual DbSet<ItemMasterChange> ItemMasterChanges { get; set; }

    public virtual DbSet<ItemMasterNx> ItemMasterNxes { get; set; }

    public virtual DbSet<ItemMasterOld> ItemMasterOlds { get; set; }

    public virtual DbSet<ItemMasterxx> ItemMasterxxes { get; set; }

    public virtual DbSet<ItemPartMaster> ItemPartMasters { get; set; }

    public virtual DbSet<ItemTypeMaster> ItemTypeMasters { get; set; }

    public virtual DbSet<JournalEntryDelete> JournalEntryDeletes { get; set; }

    public virtual DbSet<JournalEntryDtl> JournalEntryDtls { get; set; }

    public virtual DbSet<JournalEntryHed> JournalEntryHeds { get; set; }

    public virtual DbSet<LoadDetail> LoadDetails { get; set; }

    public virtual DbSet<LoadHeader> LoadHeaders { get; set; }

    public virtual DbSet<LoadingSheet> LoadingSheets { get; set; }

    public virtual DbSet<LocationMaster> LocationMasters { get; set; }

    public virtual DbSet<LoginHistory> LoginHistories { get; set; }

    public virtual DbSet<MeasureUnitMaster> MeasureUnitMasters { get; set; }

    public virtual DbSet<OrderDtl> OrderDtls { get; set; }

    public virtual DbSet<OrderHeader> OrderHeaders { get; set; }

    public virtual DbSet<OverPaySetDetail> OverPaySetDetails { get; set; }

    public virtual DbSet<OverPaySetDetailsOp> OverPaySetDetailsOps { get; set; }

    public virtual DbSet<OverPaySetHed> OverPaySetHeds { get; set; }

    public virtual DbSet<OverPayment> OverPayments { get; set; }

    public virtual DbSet<PaymentVoucherChequeDtl> PaymentVoucherChequeDtls { get; set; }

    public virtual DbSet<PaymentVoucherChequeDtlXx> PaymentVoucherChequeDtlXxes { get; set; }

    public virtual DbSet<PaymentVoucherDelete> PaymentVoucherDeletes { get; set; }

    public virtual DbSet<PaymentVoucherDtl> PaymentVoucherDtls { get; set; }

    public virtual DbSet<PaymentVoucherHed> PaymentVoucherHeds { get; set; }

    public virtual DbSet<PettyCashBookHed> PettyCashBookHeds { get; set; }

    public virtual DbSet<PettyCashBookHedDelete> PettyCashBookHedDeletes { get; set; }

    public virtual DbSet<PettyCashDtl> PettyCashDtls { get; set; }

    public virtual DbSet<PriceGroup> PriceGroups { get; set; }

    public virtual DbSet<PriceGroupMaster> PriceGroupMasters { get; set; }

    public virtual DbSet<ProcessDetail> ProcessDetails { get; set; }

    public virtual DbSet<ProductionDetail> ProductionDetails { get; set; }

    public virtual DbSet<ProductionHeader> ProductionHeaders { get; set; }

    public virtual DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }

    public virtual DbSet<PurchaseReturnHeader> PurchaseReturnHeaders { get; set; }

    public virtual DbSet<PurchaseReturnx> PurchaseReturnxes { get; set; }

    public virtual DbSet<ReceiptDtl> ReceiptDtls { get; set; }

    public virtual DbSet<ReceiptsChequeDtl> ReceiptsChequeDtls { get; set; }

    public virtual DbSet<ReceiptsHedDeleted> ReceiptsHedDeleteds { get; set; }

    public virtual DbSet<RowItemToMenuDetail> RowItemToMenuDetails { get; set; }

    public virtual DbSet<SalesRepMaster> SalesRepMasters { get; set; }

    public virtual DbSet<SalesRepMasterHga> SalesRepMasterHgas { get; set; }

    public virtual DbSet<SalesReturnDtl> SalesReturnDtls { get; set; }

    public virtual DbSet<SalesReturnHeader> SalesReturnHeaders { get; set; }

    public virtual DbSet<SpoAppDeptorsList> SpoAppDeptorsLists { get; set; }

    public virtual DbSet<SpoAppRepSale> SpoAppRepSales { get; set; }

    public virtual DbSet<SpoAppRepSalesMonthly> SpoAppRepSalesMonthlies { get; set; }

    public virtual DbSet<SpoAppReturnsCheque> SpoAppReturnsCheques { get; set; }

    public virtual DbSet<StockAdjustment> StockAdjustments { get; set; }

    public virtual DbSet<StockHistory> StockHistories { get; set; }

    public virtual DbSet<StockHistoryDaily> StockHistoryDailies { get; set; }

    public virtual DbSet<StockProcess> StockProcesses { get; set; }

    public virtual DbSet<StockVihicleHistory> StockVihicleHistories { get; set; }

    public virtual DbSet<StockVihicleHistoryDaily> StockVihicleHistoryDailies { get; set; }

    public virtual DbSet<SupplierMaster> SupplierMasters { get; set; }

    public virtual DbSet<TempDataView> TempDataViews { get; set; }

    public virtual DbSet<TempGl> TempGls { get; set; }

    public virtual DbSet<TempLedgerCard> TempLedgerCards { get; set; }

    public virtual DbSet<TempOrder> TempOrders { get; set; }

    public virtual DbSet<TempPaymentCashBook> TempPaymentCashBooks { get; set; }

    public virtual DbSet<TempPettyCashBook> TempPettyCashBooks { get; set; }

    public virtual DbSet<TempRptCustomreBalance> TempRptCustomreBalances { get; set; }

    public virtual DbSet<TempStockCard> TempStockCards { get; set; }

    public virtual DbSet<TempUpdateTransaction> TempUpdateTransactions { get; set; }

    public virtual DbSet<TestError1> TestError1s { get; set; }

    public virtual DbSet<TestError2> TestError2s { get; set; }

    public virtual DbSet<TransferInDetail> TransferInDetails { get; set; }

    public virtual DbSet<TransferInHeader> TransferInHeaders { get; set; }

    public virtual DbSet<TypeMaster> TypeMasters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsersHega> UsersHegas { get; set; }

    public virtual DbSet<VehicleItemDetail> VehicleItemDetails { get; set; }

    public virtual DbSet<VehicleMaster> VehicleMasters { get; set; }

    public virtual DbSet<VehicleReturn> VehicleReturns { get; set; }

    public virtual DbSet<VieComboLoadCustomer> VieComboLoadCustomers { get; set; }

    public virtual DbSet<VieCommissionCheque> VieCommissionCheques { get; set; }

    public virtual DbSet<VieCommissionCnote> VieCommissionCnotes { get; set; }

    public virtual DbSet<VieCommissionInvoice> VieCommissionInvoices { get; set; }

    public virtual DbSet<VieCommissionPayment> VieCommissionPayments { get; set; }

    public virtual DbSet<VieDataViewBalanceHistory> VieDataViewBalanceHistories { get; set; }

    public virtual DbSet<VieDataViewBill> VieDataViewBills { get; set; }

    public virtual DbSet<VieDataViewJournalEntry> VieDataViewJournalEntries { get; set; }

    public virtual DbSet<VieDisInvoiceLoading> VieDisInvoiceLoadings { get; set; }

    public virtual DbSet<VieDisInvoiceNunIssued> VieDisInvoiceNunIssueds { get; set; }

    public virtual DbSet<VieInfDayEnd> VieInfDayEnds { get; set; }

    public virtual DbSet<VieInfOrdersPending> VieInfOrdersPendings { get; set; }

    public virtual DbSet<VieRecItemDetail> VieRecItemDetails { get; set; }

    public virtual DbSet<VieRecItemMaster> VieRecItemMasters { get; set; }

    public virtual DbSet<VieRecItemPriceDetail> VieRecItemPriceDetails { get; set; }

    public virtual DbSet<VieRptBinCard> VieRptBinCards { get; set; }

    public virtual DbSet<VieRptCreditPayment> VieRptCreditPayments { get; set; }

    public virtual DbSet<VieRptDebtorListAGrn> VieRptDebtorListAGrns { get; set; }

    public virtual DbSet<VieRptDebtorListAOverCnote> VieRptDebtorListAOverCnotes { get; set; }

    public virtual DbSet<VieRptDebtorListAOverCollection> VieRptDebtorListAOverCollections { get; set; }

    public virtual DbSet<VieRptDebtorsBalancePriceTemp1> VieRptDebtorsBalancePriceTemp1s { get; set; }

    public virtual DbSet<VieRptInfoTakeDesDelete> VieRptInfoTakeDesDeletes { get; set; }

    public virtual DbSet<VieRptItemMaster> VieRptItemMasters { get; set; }

    public virtual DbSet<VieRptItemStock> VieRptItemStocks { get; set; }

    public virtual DbSet<VieRptJournalEntry> VieRptJournalEntries { get; set; }

    public virtual DbSet<VieRptLedgerCard> VieRptLedgerCards { get; set; }

    public virtual DbSet<VieRptLedgerCardCheque> VieRptLedgerCardCheques { get; set; }

    public virtual DbSet<VieRptLedgerCardDebit> VieRptLedgerCardDebits { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempBf> VieRptMainStockSummaryTempBfs { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempCf> VieRptMainStockSummaryTempCfs { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempGoodsIssue> VieRptMainStockSummaryTempGoodsIssues { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempLoading> VieRptMainStockSummaryTempLoadings { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempLoadingActualLosding> VieRptMainStockSummaryTempLoadingActualLosdings { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempPurchase> VieRptMainStockSummaryTempPurchases { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempSreturn> VieRptMainStockSummaryTempSreturns { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempStockIn> VieRptMainStockSummaryTempStockIns { get; set; }

    public virtual DbSet<VieRptMainStockSummaryTempTransferIn> VieRptMainStockSummaryTempTransferIns { get; set; }

    public virtual DbSet<VieRptOrdersList> VieRptOrdersLists { get; set; }

    public virtual DbSet<VieRptOrdersListCheque> VieRptOrdersListCheques { get; set; }

    public virtual DbSet<VieRptOrdersListCredit> VieRptOrdersListCredits { get; set; }

    public virtual DbSet<VieRptOrdersListSummary> VieRptOrdersListSummaries { get; set; }

    public virtual DbSet<VieRptOrdersLoading> VieRptOrdersLoadings { get; set; }

    public virtual DbSet<VieRptOrdersLoadingCustomer> VieRptOrdersLoadingCustomers { get; set; }

    public virtual DbSet<VieRptOrdersLoadingCustomersSaved> VieRptOrdersLoadingCustomersSaveds { get; set; }

    public virtual DbSet<VieRptPaymentCashBook> VieRptPaymentCashBooks { get; set; }

    public virtual DbSet<VieRptPaymentVoucherBill> VieRptPaymentVoucherBills { get; set; }

    public virtual DbSet<VieRptPaymentVoucherDtl> VieRptPaymentVoucherDtls { get; set; }

    public virtual DbSet<VieRptPaymentVoucherHed> VieRptPaymentVoucherHeds { get; set; }

    public virtual DbSet<VieRptTrialBalance> VieRptTrialBalances { get; set; }

    public virtual DbSet<VieRptTrnsJournalEntry> VieRptTrnsJournalEntries { get; set; }

    public virtual DbSet<VieRptTrnsPayment> VieRptTrnsPayments { get; set; }

    public virtual DbSet<VieRptTrnsPurchase> VieRptTrnsPurchases { get; set; }

    public virtual DbSet<VieRptTrnsUnsettled> VieRptTrnsUnsettleds { get; set; }

    public virtual DbSet<VieStockCardGrn> VieStockCardGrns { get; set; }

    public virtual DbSet<VieStockCardLoad> VieStockCardLoads { get; set; }

    public virtual DbSet<ViewInfChequsRealized> ViewInfChequsRealizeds { get; set; }

    public virtual DbSet<ViewRptCustomerwiseSale> ViewRptCustomerwiseSales { get; set; }

    public virtual DbSet<XJournalEntryDtl> XJournalEntryDtls { get; set; }

    public virtual DbSet<XJournalEntryHed> XJournalEntryHeds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ATestChequeTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("A_Test_chequeTotal");

            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
        });

        modelBuilder.Entity<AccountBalance>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.DataDate).HasColumnType("datetime");
            entity.Property(e => e.RMonth).HasColumnName("R_Month");
            entity.Property(e => e.RYear).HasColumnName("R_Year");
        });

        modelBuilder.Entity<AccountMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountMaster");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BalancetoDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.MainAccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OpeningBalance).HasColumnType("money");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<AccountTransaction>(entity =>
        {
            entity.HasKey(e => new { e.AccTransactionNo, e.TransactionNo });

            entity.ToTable("AccountTransaction");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DorC)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ReferanceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Refype)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TrDate).HasColumnType("datetime");
            entity.Property(e => e.TrDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccountTypeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountTypeMaster");

            entity.Property(e => e.TypeName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppNewRepSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("app_new_RepSales");

            entity.Property(e => e.TotalSale).HasColumnType("money");
        });

        modelBuilder.Entity<AreaMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AreaMaster");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BalanceHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BalanceHistory");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DorC)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<BankMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BankMaster");

            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillsDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillsDtl");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmountSettled).HasColumnType("money");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDiscount).HasColumnType("money");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<BillsHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillsHED");

            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
            entity.Property(e => e.Grnnumber).HasColumnName("GRNNumber");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<CategoryMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CategoryMaster");

            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CategoryDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChangeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChangeHistory");

            entity.Property(e => e.ChangeDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NewValue).HasColumnType("money");
            entity.Property(e => e.OldValue).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ChequeFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChequeFile");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DisBerDate).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ChequeFileNx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChequeFileNx");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DisBerDate).HasColumnType("datetime");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CodeFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CodeFile");

            entity.Property(e => e.Cnnumber).HasColumnName("CNNumber");
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.Ginumber).HasColumnName("GINumber");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Jenumber).HasColumnName("JENumber");
            entity.Property(e => e.Srnumber).HasColumnName("SRNumber");
        });

        modelBuilder.Entity<CollectionSheetCheque>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaiedAmount).HasColumnType("money");
        });

        modelBuilder.Entity<CollectionSheetDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CollectionSheetDtl");

            entity.Property(e => e.BillNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaiedAmount).HasColumnType("money");
            entity.Property(e => e.TotalCash).HasColumnType("money");
            entity.Property(e => e.TotalCheque).HasColumnType("money");
            entity.Property(e => e.Trnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRNumber");
        });

        modelBuilder.Entity<CollectionSheetHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CollectionSheetHed");

            entity.Property(e => e.BookNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CollectedDate).HasColumnType("datetime");
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalCash).HasColumnType("money");
            entity.Property(e => e.TotalCheque).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CollectorMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CollectorMaster");

            entity.Property(e => e.CollectorName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Colour>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Colour1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Colour");
            entity.Property(e => e.Corder).HasColumnName("COrder");
        });

        modelBuilder.Entity<CompanyFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyFile");

            entity.Property(e => e.Bttactive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BTTActive");
            entity.Property(e => e.Bttper)
                .HasColumnType("money")
                .HasColumnName("BTTPer");
            entity.Property(e => e.CompanyAddress)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompanyTel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DayEnd).HasColumnType("datetime");
            entity.Property(e => e.GoodStart)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastLogingDate).HasColumnType("datetime");
            entity.Property(e => e.LastLogingDateDaily).HasColumnType("datetime");
            entity.Property(e => e.Vatactive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VATActive");
            entity.Property(e => e.Vatper)
                .HasColumnType("money")
                .HasColumnName("VATPer");
        });

        modelBuilder.Entity<CompanyMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyMaster");

            entity.Property(e => e.Grnnumber).HasColumnName("GRNNumber");
            entity.Property(e => e.InvoiceNoCn)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InvoiceNoCN");
            entity.Property(e => e.InvoiceNoCv)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InvoiceNoCV");
            entity.Property(e => e.InvoiceNoD1)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNoD2)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNoRn)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InvoiceNoRN");
            entity.Property(e => e.InvoiceNoRv)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("InvoiceNoRV");
            entity.Property(e => e.SystemCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SystemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SystemType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CreditNote>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BookNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cndate)
                .HasColumnType("datetime")
                .HasColumnName("CNDate");
            entity.Property(e => e.Cnnumber).HasColumnName("CNNumber");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.OverPay).HasColumnType("money");
            entity.Property(e => e.Srnumber).HasColumnName("SRNumber");
            entity.Property(e => e.Userid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CreditNotesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CreditNotes_Details");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Cnnumber).HasColumnName("CNNumber");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<CustomerCreditControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerCreditControl");

            entity.Property(e => e.BankCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreditAmount).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OldInvoice)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptsNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SettledAmount).HasColumnType("money");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CustomerCreditControlNx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerCreditControlNx");

            entity.Property(e => e.CreditAmount).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OldInvoice)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptsNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SettledAmount).HasColumnType("money");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<CustomerMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerMaster");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Image).IsUnicode(false);
            entity.Property(e => e.NicNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Others)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SvatNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SVatNo");
            entity.Property(e => e.Tel)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VatNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerMasterNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerMasterNew");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreditLimit).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Fax)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Image).IsUnicode(false);
            entity.Property(e => e.NicNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Others)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SvatNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SVatNo");
            entity.Property(e => e.Tel)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VatNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerOrderHeader2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerOrderHeader2");

            entity.Property(e => e.Adpay)
                .HasColumnType("money")
                .HasColumnName("ADPay");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RepPodate)
                .HasColumnType("datetime")
                .HasColumnName("RepPODate");
            entity.Property(e => e.RepPono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RepPONo");
            entity.Property(e => e.RequestDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<DamegeItemHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DamegeItemHeader");

            entity.Property(e => e.AcceptedUser)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DateOfReceived).HasColumnType("datetime");
            entity.Property(e => e.DateOfReturn).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EntryType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OutlatCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ReturnUser)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<DamegeitemDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<DebitNote>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DebitAount).HasColumnType("money");
            entity.Property(e => e.DebitDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Setteld).HasColumnType("money");
        });

        modelBuilder.Entity<DebitNotesHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DebitNotes_Hed");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BookNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cndate)
                .HasColumnType("datetime")
                .HasColumnName("CNDate");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dnnumber).HasColumnName("DNNumber");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.OverPay).HasColumnType("money");
            entity.Property(e => e.Srnumber).HasColumnName("SRNumber");
            entity.Property(e => e.Userid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<DebtorsHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Debtors_Hed");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.Category)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DataDate).HasColumnType("datetime");
            entity.Property(e => e.RMonth).HasColumnName("R_Month");
            entity.Property(e => e.RYear).HasColumnName("R_Year");
        });

        modelBuilder.Entity<DepreciationMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DepreciationMaster");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReduseMethord)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmployeeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeMaster");

            entity.Property(e => e.EmployeeCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeLocation)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FixedAssetDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FixedAssetDTL");

            entity.Property(e => e.DepreciationAmount).HasColumnType("money");
        });

        modelBuilder.Entity<FixedAssetHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FixedAssetHED");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Depreciation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DepriciationValue).HasColumnType("money");
            entity.Property(e => e.FabookNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FABookNo");
            entity.Property(e => e.NowValue).HasColumnType("money");
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GoodsIssuedDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GoodsIssuedDTL");

            entity.Property(e => e.Ginumber).HasColumnName("GINumber");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GoodsIssuedHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GoodsIssuedHED");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Ginumber).HasColumnName("GINumber");
            entity.Property(e => e.IssuedDate).HasColumnType("datetime");
            entity.Property(e => e.IssuedType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SlipNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<GoodsTransferDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GoodsTransferDTL");

            entity.Property(e => e.Gtnumber).HasColumnName("GTNumber");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GoodsTransferHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GoodsTransferHED");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Gtnumber).HasColumnName("GTNumber");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehicleCodeFrom)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehicleCodeTo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Grndtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRNDtl");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.AmountSettled).HasColumnType("money");
            entity.Property(e => e.Grnnumber).HasColumnName("GRNNumber");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemDiscount).HasColumnType("money");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<Grnhed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRNHED");

            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
            entity.Property(e => e.Grnnumber).HasColumnName("GRNNumber");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<GroupMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupMaster");

            entity.Property(e => e.GroupCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.GroupName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.GroupName2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => new { e.ReceiptComputerCode, e.ItemCode });

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ColourDes).HasMaxLength(500);
            entity.Property(e => e.CostPrice).HasColumnType("money");
            entity.Property(e => e.DisPer).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<InvoiceDetailsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvoiceDetailsOld");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.ReturnedC).HasColumnType("money");
            entity.Property(e => e.ReturnedP).HasColumnType("money");
            entity.Property(e => e.SoldPrice).HasColumnType("money");
            entity.Property(e => e.SystemCode)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InvoiceHeader>(entity =>
        {
            entity.HasKey(e => e.ReceiptComputerCode);

            entity.ToTable("InvoiceHeader");

            entity.Property(e => e.ReceiptComputerCode).ValueGeneratedNever();
            entity.Property(e => e.Adpay)
                .HasColumnType("money")
                .HasColumnName("ADPay");
            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cash).HasColumnType("money");
            entity.Property(e => e.Cheque).HasColumnType("money");
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Nbtamount)
                .HasColumnType("money")
                .HasColumnName("NBTAmount");
            entity.Property(e => e.Pono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PONo");
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptsNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StockUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.SvatNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SVatNo");
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VatAmount).HasColumnType("money");
            entity.Property(e => e.VatNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<InvoiceHeaderOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvoiceHeaderOld");

            entity.Property(e => e.AmountForCommission).HasColumnType("money");
            entity.Property(e => e.BillPrint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cash).HasColumnType("money");
            entity.Property(e => e.CashReceived).HasColumnType("money");
            entity.Property(e => e.Cheque).HasColumnType("money");
            entity.Property(e => e.CommissionPaid).HasColumnType("money");
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.CreditCard).HasColumnType("money");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerVatAddress)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomerVatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerVatNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Dtype)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DType");
            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceTime).HasColumnType("datetime");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PaymentType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SoldBy)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SystemCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalCommission).HasColumnType("money");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.TotalVat).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VatType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemMaster");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActiveItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ColorActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IncAccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemImage).HasColumnType("image");
            entity.Property(e => e.ItemType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastIssuesDate).HasColumnType("datetime");
            entity.Property(e => e.LastIssuesPrice).HasColumnType("money");
            entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Make)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderQty)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PartCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrintDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SpecialPrice).HasColumnType("money");
            entity.Property(e => e.SysCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WholesalePrice).HasColumnType("money");
        });

        modelBuilder.Entity<ItemMasterChange>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemMasterChange");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PrintDescription1)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItemMasterNx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemMasterNx");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActiveItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ColorActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IncAccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemImage).HasColumnType("image");
            entity.Property(e => e.ItemType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastIssuesDate).HasColumnType("datetime");
            entity.Property(e => e.LastIssuesPrice).HasColumnType("money");
            entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Make)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderQty)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PartCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrintDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SpecialPrice).HasColumnType("money");
            entity.Property(e => e.SysCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WholesalePrice).HasColumnType("money");
        });

        modelBuilder.Entity<ItemMasterOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemMasterOLD");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActiveItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ColorActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IncAccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemImage).HasColumnType("image");
            entity.Property(e => e.ItemType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastIssuesDate).HasColumnType("datetime");
            entity.Property(e => e.LastIssuesPrice).HasColumnType("money");
            entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Make)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderQty)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PartCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrintDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SpecialPrice).HasColumnType("money");
            entity.Property(e => e.SysCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WholesalePrice).HasColumnType("money");
        });

        modelBuilder.Entity<ItemMasterxx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemMasterxx");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActiveItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ColorActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IncAccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemImage).HasColumnType("image");
            entity.Property(e => e.ItemType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastIssuesDate).HasColumnType("datetime");
            entity.Property(e => e.LastIssuesPrice).HasColumnType("money");
            entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Make)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderQty)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PartCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrintDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SpecialPrice).HasColumnType("money");
            entity.Property(e => e.SysCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WholesalePrice).HasColumnType("money");
        });

        modelBuilder.Entity<ItemPartMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemPartMaster");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.PartCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PartDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItemTypeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemTypeMaster");

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemTypeCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemTypeDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JournalEntryDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JournalEntry_Delete");

            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JournalEntryDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JournalEntryDtl");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CorD)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Reftype)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JournalEntryHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JournalEntryHed");

            entity.Property(e => e.BookNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Cnnumber).HasColumnName("CNNumber");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Jeamount)
                .HasColumnType("money")
                .HasColumnName("JEAmount");
            entity.Property(e => e.Jedate)
                .HasColumnType("datetime")
                .HasColumnName("JEDate");
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<LoadDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoadHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoadHeader");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.LoadDate).HasColumnType("datetime");
            entity.Property(e => e.SlipNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<LoadingSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoadingSheet");

            entity.Property(e => e.Colour)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoadDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<LocationMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LocationMaster");

            entity.Property(e => e.LocationCode)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LoginHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoginHistory");

            entity.Property(e => e.InDate)
                .HasColumnType("datetime")
                .HasColumnName("inDate");
            entity.Property(e => e.InTime)
                .HasColumnType("datetime")
                .HasColumnName("inTime");
            entity.Property(e => e.Login)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LoginId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OutDate)
                .HasColumnType("datetime")
                .HasColumnName("outDate");
            entity.Property(e => e.OutTime)
                .HasColumnType("datetime")
                .HasColumnName("outTime");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProgramType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<MeasureUnitMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MeasureUnitMaster");

            entity.Property(e => e.MainMesur)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Qty).HasColumnName("QTy");
        });

        modelBuilder.Entity<OrderDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderDtl");

            entity.Property(e => e.ColourDes).HasMaxLength(500);
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<OrderHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OrderHeader");

            entity.Property(e => e.Adpay)
                .HasColumnType("money")
                .HasColumnName("ADPay");
            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cash).HasColumnType("money");
            entity.Property(e => e.Cheque).HasColumnType("money");
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Nbtamount)
                .HasColumnType("money")
                .HasColumnName("NBTAmount");
            entity.Property(e => e.OrderState)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PONo");
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptsNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SvatNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SVatNo");
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VatAmount).HasColumnType("money");
            entity.Property(e => e.VatNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<OverPaySetDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OverPaySet_Details");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Opsumber).HasColumnName("OPSumber");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<OverPaySetDetailsOp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OverPaySet_Details_OP");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Opnumber).HasColumnName("OPNumber");
            entity.Property(e => e.Opsumber).HasColumnName("OPSumber");
        });

        modelBuilder.Entity<OverPaySetHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OverPaySet_HED");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BookNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Cndate)
                .HasColumnType("datetime")
                .HasColumnName("CNDate");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Opsumber).HasColumnName("OPSumber");
            entity.Property(e => e.OverPay).HasColumnType("money");
            entity.Property(e => e.Srnumber).HasColumnName("SRNumber");
            entity.Property(e => e.Userid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<OverPayment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Opaount)
                .HasColumnType("money")
                .HasColumnName("OPAount");
            entity.Property(e => e.Opdate)
                .HasColumnType("datetime")
                .HasColumnName("OPDate");
            entity.Property(e => e.Opnumber).HasColumnName("OPNumber");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Remarks ");
            entity.Property(e => e.Settled).HasColumnType("money");
        });

        modelBuilder.Entity<PaymentVoucherChequeDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentVoucherChequeDtl");

            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferanceInvoice)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaymentVoucherChequeDtlXx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentVoucherChequeDtlXX");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferanceInvoice)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaymentVoucherDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentVoucher_Delete");

            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Reason)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PaymentVoucherDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentVoucherDtl");

            entity.Property(e => e.AmountPaid).HasColumnType("money");
        });

        modelBuilder.Entity<PaymentVoucherHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PaymentVoucherHed");

            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.BookVoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<PettyCashBookHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PettyCashBookHED");

            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<PettyCashBookHedDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PettyCashBookHED_Delete");

            entity.Property(e => e.DeleteDate).HasColumnType("datetime");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PettyCashDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PettyCashDtl");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<PriceGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PriceGroup");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<PriceGroupMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PriceGroupMaster");

            entity.Property(e => e.PriceDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProcessDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DebtorsProcess)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonthEndProcess)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ProductionDetail>(entity =>
        {
            entity.HasKey(e => new { e.ProductionNumber, e.ItemCode });

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<ProductionHeader>(entity =>
        {
            entity.HasKey(e => e.ProductionNumber);

            entity.ToTable("ProductionHeader");

            entity.Property(e => e.ProductionNumber).ValueGeneratedNever();
            entity.Property(e => e.CheckedBy)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("date");
            entity.Property(e => e.ProductDate).HasColumnType("date");
            entity.Property(e => e.Remarks)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<PurchaseReturnDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseReturnUnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<PurchaseReturnHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseReturnHeader");

            entity.Property(e => e.Approved)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Collected)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnteredUserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Grnnumber).HasColumnName("GRNNumber");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.Returned)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TotalPurchasePrice).HasColumnType("money");
        });

        modelBuilder.Entity<PurchaseReturnx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PurchaseReturnx");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ReceiptDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReceiptDtl");

            entity.Property(e => e.DueAmount).HasColumnType("money");
            entity.Property(e => e.InvoiceAmount).HasColumnType("money");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReceiptsChequeDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReceiptsChequeDtl");

            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferanceInvoice)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReceiptsHedDeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReceiptsHed_Deleted");

            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BookReceiptNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CaccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAccountCode");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DaccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DAccountCode");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptAmount).HasColumnType("money");
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<RowItemToMenuDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ItemCodeMenu)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemCodeRow)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Qty).HasColumnName("QTY");
        });

        modelBuilder.Entity<SalesRepMaster>(entity =>
        {
            entity.HasKey(e => e.RepCode);

            entity.ToTable("SalesRepMaster");

            entity.Property(e => e.RepCode).ValueGeneratedNever();
            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.RepAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RepAvtive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RepLastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.RepName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RepTelMobile)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RepTelResident)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesRepMasterHga>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SalesRepMaster_Hga");

            entity.Property(e => e.RepName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SalesReturnDtl>(entity =>
        {
            entity.HasKey(e => new { e.Srnumber, e.ItemCode });

            entity.ToTable("SalesReturnDTL");

            entity.Property(e => e.Srnumber).HasColumnName("SRNumber");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<SalesReturnHeader>(entity =>
        {
            entity.HasKey(e => e.Srnumber);

            entity.ToTable("SalesReturnHeader");

            entity.Property(e => e.Srnumber)
                .ValueGeneratedNever()
                .HasColumnName("SRNumber");
            entity.Property(e => e.AcceptedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CaccountCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAccountCode");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Grnnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GRNNumber");
            entity.Property(e => e.OldInvoice)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remarks)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.Rupees)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<SpoAppDeptorsList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("spo_app_DeptorsList");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.CreditAmount).HasColumnType("money");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.SettledAmount).HasColumnType("money");
        });

        modelBuilder.Entity<SpoAppRepSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("spo_app_RepSales");

            entity.Property(e => e.TotalReturns).HasColumnType("money");
            entity.Property(e => e.TotalSale).HasColumnType("money");
        });

        modelBuilder.Entity<SpoAppRepSalesMonthly>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("spo_app_RepSales_monthly");

            entity.Property(e => e.TotalSale).HasColumnType("money");
        });

        modelBuilder.Entity<SpoAppReturnsCheque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("spo_app_ReturnsCheques");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Details)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StockAdjustment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AdjustmentDate).HasColumnType("datetime");
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.NewAvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.NewLastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.NewRetailPrice).HasColumnType("money");
            entity.Property(e => e.NewSpecialPrice).HasColumnType("money");
            entity.Property(e => e.NewWholesalePrice).HasColumnType("money");
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SpecialPrice).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WholesalePrice).HasColumnType("money");
        });

        modelBuilder.Entity<StockHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockHistory");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastLogingDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseCasePrice).HasColumnType("money");
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.WholesaleCasePrice).HasColumnType("money");
        });

        modelBuilder.Entity<StockHistoryDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockHistory_Daily");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastLogingDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseCasePrice).HasColumnType("money");
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.WholesaleCasePrice).HasColumnType("money");
        });

        modelBuilder.Entity<StockProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockProcess");

            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<StockVihicleHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockVihicleHistory");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastLogingDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<StockVihicleHistoryDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockVihicleHistory_Daily");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastLogingDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<SupplierMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SupplierMaster");

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ChequeTitle)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate)
                .HasColumnType("datetime")
                .HasColumnName("entryDate");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SupplierType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Vat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TempDataView>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_Data_View");

            entity.Property(e => e.AccountCodeFrom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountCodeTo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.ChrCodeFrom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChrCodeTo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
            entity.Property(e => e.DayEndDate).HasColumnType("date");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<TempGl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_GL");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.Debit).HasColumnType("money");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Gldate)
                .HasColumnType("datetime")
                .HasColumnName("GLDate");
            entity.Property(e => e.RefDes)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempLedgerCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_LedgerCard");

            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.Category)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DataDate).HasColumnType("datetime");
            entity.Property(e => e.Debit).HasColumnType("money");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RDate)
                .HasColumnType("datetime")
                .HasColumnName("R_Date");
            entity.Property(e => e.RMonth).HasColumnName("R_Month");
            entity.Property(e => e.RYear).HasColumnName("R_Year");
            entity.Property(e => e.RefNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_Orders");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TempPaymentCashBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_Payment_CashBook");

            entity.Property(e => e.AccCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Supplier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempPettyCashBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_PettyCashBook");

            entity.Property(e => e.AccName)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TempRptCustomreBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_rpt_CustomreBalance");

            entity.Property(e => e.A30).HasColumnType("money");
            entity.Property(e => e.A60).HasColumnType("money");
            entity.Property(e => e.A90).HasColumnType("money");
            entity.Property(e => e.Av90)
                .HasColumnType("money")
                .HasColumnName("AV90");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempStockCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_StockCard");

            entity.Property(e => e.Des)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TempUpdateTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Temp_UpdateTransaction");

            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.BookVoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TestError1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("test_error1");

            entity.Property(e => e.AsTotalAmount)
                .HasColumnType("money")
                .HasColumnName("asTotalAmount");
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
        });

        modelBuilder.Entity<TestError2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("test_Error2");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Def)
                .HasColumnType("money")
                .HasColumnName("def");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TransferInDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<TransferInHeader>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransferInHeader");

            entity.Property(e => e.AcceptedUser)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.DateOfReceived).HasColumnType("datetime");
            entity.Property(e => e.DateOfTransfer).HasColumnType("datetime");
            entity.Property(e => e.EntryType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Entrydate).HasColumnType("datetime");
            entity.Property(e => e.LocationCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ReturnUser)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TypeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TypeMaster");

            entity.Property(e => e.TypeCode)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.TypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TypeName2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Password).IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsersHega>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Users_Hega");

            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UserLevel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UserName)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VehicleItemDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VehicleMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VehicleMaster");

            entity.Property(e => e.Root)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnloadDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehicleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VehicleReturn>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieComboLoadCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_ComboLoad_Customer");

            entity.Property(e => e.Customer)
                .HasMaxLength(109)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieCommissionCheque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Commission_Cheques");

            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VieCommissionCnote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Commission_CNotes");

            entity.Property(e => e.DateFrom).HasColumnType("datetime");
        });

        modelBuilder.Entity<VieCommissionInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Commission_Invoices");

            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VieCommissionPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Commission_Payment");

            entity.Property(e => e.DateFrom).HasColumnType("datetime");
        });

        modelBuilder.Entity<VieDataViewBalanceHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_DataView_BalanceHistory");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DorC)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VieDataViewBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_DataView_Bills");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieDataViewJournalEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_DataView_JournalEntry");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Jeamount)
                .HasColumnType("money")
                .HasColumnName("JEAmount");
            entity.Property(e => e.Jedate)
                .HasColumnType("datetime")
                .HasColumnName("JEDate");
        });

        modelBuilder.Entity<VieDisInvoiceLoading>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Dis_Invoice_Loading");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieDisInvoiceNunIssued>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Dis_Invoice_NunIssued");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieInfDayEnd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_inf_DayEnd");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VehicleCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieInfOrdersPending>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_inf_OrdersPending");

            entity.Property(e => e.ColourDes).HasMaxLength(500);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Pono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PONo");
        });

        modelBuilder.Entity<VieRecItemDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rec_ItemDetails");

            entity.Property(e => e.ActiveItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastIssuesDate).HasColumnType("datetime");
            entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.Make)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SysCode)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRecItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rec_ItemMaster");

            entity.Property(e => e.Active)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActiveItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ColorActive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.IncAccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemImage).HasColumnType("image");
            entity.Property(e => e.ItemType)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.LastIssuesDate).HasColumnType("datetime");
            entity.Property(e => e.LastIssuesPrice).HasColumnType("money");
            entity.Property(e => e.LastPurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Make)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrderQty)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PartCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrintDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SpecialPrice).HasColumnType("money");
            entity.Property(e => e.SysCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.WholesalePrice).HasColumnType("money");
        });

        modelBuilder.Entity<VieRecItemPriceDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rec_ItemPriceDetails");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.PriceDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptBinCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_BinCard");

            entity.Property(e => e.Des)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieRptCreditPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_CreditPayments");

            entity.Property(e => e.CreditAmount).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.ReceiptsNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SettledAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VieRptDebtorListAGrn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_DebtorList_A_GRN");

            entity.Property(e => e.Grnamount)
                .HasColumnType("money")
                .HasColumnName("GRNAmount");
        });

        modelBuilder.Entity<VieRptDebtorListAOverCnote>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_DebtorList_A_OverCNote");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OverCnoteAmount)
                .HasColumnType("money")
                .HasColumnName("OverCNoteAmount");
        });

        modelBuilder.Entity<VieRptDebtorListAOverCollection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_DebtorList_A_OverCollection");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OverPaiedAmount).HasColumnType("money");
        });

        modelBuilder.Entity<VieRptDebtorsBalancePriceTemp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vie_Rpt_Debtors_Balance_Price_Temp1");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AreaCode)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptInfoTakeDesDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_info_TakeDes_Delete");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
        });

        modelBuilder.Entity<VieRptItemMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_ItemMaster");

            entity.Property(e => e.ActiveItem)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AvaragePurchasePrice).HasColumnType("money");
            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CategoryDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.OrderQty)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RackNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
            entity.Property(e => e.SpecialPrice).HasColumnType("money");
            entity.Property(e => e.SysCode)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SystemName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WholesalePrice).HasColumnType("money");
        });

        modelBuilder.Entity<VieRptItemStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_Item_Stock");

            entity.Property(e => e.CategoryCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CategoryDescription)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ItemCode)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastPurchasePrice).HasColumnType("money");
            entity.Property(e => e.PartNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RetailPrice).HasColumnType("money");
        });

        modelBuilder.Entity<VieRptJournalEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_JournalEntry");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BookNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CorD)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Jedate)
                .HasColumnType("datetime")
                .HasColumnName("JEDate");
        });

        modelBuilder.Entity<VieRptLedgerCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_LedgerCard");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.Category)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DataDate).HasColumnType("datetime");
            entity.Property(e => e.Debit).HasColumnType("money");
            entity.Property(e => e.Details)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr1).HasColumnType("money");
            entity.Property(e => e.Expr2).HasColumnType("money");
            entity.Property(e => e.Expr3)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RDate)
                .HasColumnType("datetime")
                .HasColumnName("R_Date");
            entity.Property(e => e.RMonth).HasColumnName("R_Month");
            entity.Property(e => e.RYear).HasColumnName("R_Year");
            entity.Property(e => e.RefNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptLedgerCardCheque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_LedgerCard_Cheques");

            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.BookNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CollectedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieRptLedgerCardDebit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_LedgerCard_Debit");

            entity.Property(e => e.DebitAount).HasColumnType("money");
            entity.Property(e => e.DebitDate).HasColumnType("datetime");
            entity.Property(e => e.Setteld).HasColumnType("money");
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempBf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_BF");

            entity.Property(e => e.BfstockInCases).HasColumnName("BFStockInCases");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempCf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_CF");

            entity.Property(e => e.CfstockInCases).HasColumnName("CFStockInCases");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseCasePrice).HasColumnType("money");
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempGoodsIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_GoodsIssue");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempLoading>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_Loading");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoadQty).HasColumnName("LoadQTY");
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempLoadingActualLosding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_Loading_Actual Losding");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LoadQty).HasColumnName("LoadQTY");
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempPurchase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_Purchases");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseQty).HasColumnName("PurchaseQTY");
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempSreturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_SReturn");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempStockIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_StockIn");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptMainStockSummaryTempTransferIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_Rpt_MainStockSummary_Temp_TransferIN");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TranferIn).HasColumnName("TranferIN");
        });

        modelBuilder.Entity<VieRptOrdersList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_Orders_List");

            entity.Property(e => e.A30).HasColumnType("money");
            entity.Property(e => e.A60).HasColumnType("money");
            entity.Property(e => e.A90).HasColumnType("money");
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AreaName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Av90)
                .HasColumnType("money")
                .HasColumnName("AV90");
            entity.Property(e => e.Balance).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cheques).HasColumnType("money");
            entity.Property(e => e.ContactName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Fax)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Tel)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptOrdersListCheque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_Orders_List_Cheques");

            entity.Property(e => e.BankCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cheques).HasColumnType("money");
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ShortName)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptOrdersListCredit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_Orders_List_Credit");

            entity.Property(e => e.Balanced).HasColumnType("money");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieRptOrdersListSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_Orders_List_Summary");

            entity.Property(e => e.AstotalQty).HasColumnName("ASTotalQty");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptOrdersLoading>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_Orders_Loading");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptOrdersLoadingCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_Orders_Loading_Customers");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ColourDes).HasMaxLength(500);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReceiptDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VieRptOrdersLoadingCustomersSaved>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_Orders_Loading_Customers_Saved");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Colour)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LoadDate).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VieRptPaymentCashBook>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_PaymentCashBook");

            entity.Property(e => e.AccCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Supplier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TrDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VieRptPaymentVoucherBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_PaymentVoucher_Bills");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptPaymentVoucherDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_PaymentVoucher_Dtl");

            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptPaymentVoucherHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_PaymentVoucher_Hed");

            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BookVoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VieRptTrialBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_trial_Balance");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.DorC)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VieRptTrnsJournalEntry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_trns_JournalEntry");

            entity.Property(e => e.AccountCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BookNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CorD)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Jedate)
                .HasColumnType("datetime")
                .HasColumnName("JEDate");
        });

        modelBuilder.Entity<VieRptTrnsPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_trns_Payments");

            entity.Property(e => e.AmountPaid).HasColumnType("money");
            entity.Property(e => e.BookVoucherNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Expr1)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Expr2).HasColumnType("datetime");
            entity.Property(e => e.Expr3).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Remarks)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<VieRptTrnsPurchase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_trns_Purchases");

            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<VieRptTrnsUnsettled>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_rpt_trns_Unsettled");

            entity.Property(e => e.BillAmount).HasColumnType("money");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.DateFrom).HasColumnType("datetime");
            entity.Property(e => e.DateTo).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.EntryTime).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaidAmount).HasColumnType("money");
            entity.Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Remarks)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<VieStockCardGrn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_StockCard_GRN");

            entity.Property(e => e.Expr1)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Expr3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VieStockCardLoad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vie_StockCard_Load");

            entity.Property(e => e.Expr1)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Expr2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LoadDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewInfChequsRealized>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_inf_Chequs_Realized");

            entity.Property(e => e.BankName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ChequeAmount).HasColumnType("money");
            entity.Property(e => e.ChequeDate).HasColumnType("datetime");
            entity.Property(e => e.ChequeNumber)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ChequeStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CsheetNo).HasColumnName("CSheetNo");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DisBerDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewRptCustomerwiseSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_rpt_Customerwise_Sales");

            entity.Property(e => e.Cash).HasColumnType("money");
            entity.Property(e => e.Cheque).HasColumnType("money");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.TotalDiscount).HasColumnType("money");
            entity.Property(e => e.VatAmount).HasColumnType("money");
        });

        modelBuilder.Entity<XJournalEntryDtl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xJournalEntryDtl");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.CorD)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Reftype)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<XJournalEntryHed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("xJournalEntryHed");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Jeamount)
                .HasColumnType("money")
                .HasColumnName("JEAmount");
            entity.Property(e => e.Jedate)
                .HasColumnType("datetime")
                .HasColumnName("JEDate");
            entity.Property(e => e.UserId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
