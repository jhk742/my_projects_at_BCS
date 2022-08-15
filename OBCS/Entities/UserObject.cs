using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class UserObject
    {
        //info
        public string UserStatus { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactNumber { get; set; }

        //menus
        public bool accounting { get; set; }
        public bool sales { get; set; }
        public bool accountsReceivable { get; set; }
        public bool purchaseOrder { get; set; }
        public bool accountsPayable { get; set; }
        public bool stock { get; set; }
        public bool mWMS { get; set; }
        public bool lists { get; set; }
        public bool map { get; set; }
        public bool systemMenu { get; set; }
        public bool generalJournalEntries { get; set; }
        public bool profitAndLossReport { get; set; }
        public bool salesOrder { get; set; }
        public bool auditSalesOrder { get; set; }
        public bool confirmedSalesOrder { get; set; }
        public bool preparationPlan { get; set; }
        public bool pickingTicket { get; set; }
        public bool deliveryNote { get; set; }
        public bool duplicateSalesOrder { get; set; }
        public bool deallocation { get; set; }
        public bool packageNutLabel { get; set; }
        public bool salesReport { get; set; }
        public bool packageNutLabelPrint { get; set; }
        public bool packageNutCustomerOption { get; set; }
        public bool packageNutCustomPrice { get; set; }
        public bool salesOrderExceptionReport { get; set; }
        public bool salesbyRepReport { get; set; }
        public bool salesbyCustomerReport { get; set; }
        public bool salesbyProductReport { get; set; }
        public bool salesPerformanceReport { get; set; }
        public bool nutCategorySalesReport { get; set; }
        public bool commissionReport { get; set; }
        public bool collectionfromDelivery { get; set; }
        public bool collectionfromSales { get; set; }
        public bool validation { get; set; }
        public bool invoice { get; set; }
        public bool creditMemoRequest { get; set; }
        public bool netSettlement { get; set; }
        public bool arPayment { get; set; }
        public bool entryBatch { get; set; }
        public bool deposit { get; set; }
        public bool arReports { get; set; }
        public bool arAging { get; set; }
        public bool arbyCustomerReport { get; set; }
        public bool arbySalespersonReport { get; set; }
        public bool arCollectionsSummary { get; set; }
        public bool arSalesDebitMemoSummary { get; set; }
        public bool arOverpayment { get; set; }
        public bool nonSufficientFundsReport { get; set; }
        public bool promotionSchedule { get; set; }
        public bool poPrepare { get; set; }
        public bool po { get; set; }
        public bool goodsReceipt { get; set; }
        public bool poReports { get; set; }
        public bool poExceptionReport { get; set; }
        public bool subcontractOrderExceptionReport { get; set; }
        public bool poManagementReport { get; set; }
        public bool poManagementDetailReport { get; set; }
        public bool poForecastReport { get; set; }
        public bool poDepartmentSalesReport { get; set; }
        public bool apValidation { get; set; }
        public bool apDebitNote { get; set; }
        public bool apCreditMemoRequest { get; set; }
        public bool apDebitMemoRequest { get; set; }
        public bool apNetSettlement { get; set; }
        public bool paymentResolution { get; set; }
        public bool apPayment { get; set; }
        public bool apReports { get; set; }
        public bool apAging { get; set; }
        public bool assembly { get; set; }
        public bool assemblyRecipt { get; set; }
        public bool disassembly { get; set; }
        public bool disassemblyReceipt { get; set; }
        public bool manufacturing { get; set; }
        public bool manufacturingReceipt { get; set; }
        public bool miscellaneousIssue { get; set; }
        public bool miscellaneousReceipt { get; set; }
        public bool subcontractOrder { get; set; }
        public bool subcontractReceipt { get; set; }
        public bool intersiteTransfer { get; set; }
        public bool receiptReturn { get; set; }
        public bool shipmentReturn { get; set; }
        public bool stockChange { get; set; }
        public bool stockReports { get; set; }
        public bool ipadShortageReport { get; set; }
        public bool globalShortageReport { get; set; }
        public bool detailedShortageReport { get; set; }
        public bool inventoryManagement { get; set; }
        public bool miscellaneousTransactionReport { get; set; }
        public bool stockTransactionReport { get; set; }
        public bool stockMovementReport { get; set; }
        public bool stockValuationReport { get; set; }
        public bool wmsGoodsReceipt { get; set; }
        public bool wmsStockStatusChange { get; set; }
        public bool wmsShipmentReturn { get; set; }
        public bool IntersiteTransferOrder { get; set; }
        public bool IntersiteTransferReceipt { get; set; }
        public bool wmsCustomerDelivery { get; set; }
        public bool wmsReceiptReturn { get; set; }
        public bool brandList { get; set; }
        public bool chartOfAccount { get; set; }
        public bool companyList { get; set; }
        public bool customerList { get; set; }
        public bool customerPriceEntry { get; set; }
        public bool deliveryRoutePlanList { get; set; }
        public bool driverList { get; set; }
        public bool paymentTermList { get; set; }
        public bool productList { get; set; }
        public bool promotionScheduleTypeList { get; set; }
        public bool salesPersonList { get; set; }
        public bool supplierList { get; set; }
        public bool customerMap { get; set; }
        public bool customerMapWeb { get; set; }
        public bool salesByCategoryMap { get; set; }
        public bool userMaintenance { get; set; }
        public bool writeoff { get; set; }



    }
}
