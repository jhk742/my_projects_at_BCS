using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class iPadSalesOrder
    {
        public string CdBranchCode { get; set; }		        
        public string OrderID { get; set; }     
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string TraderEntityKey { get; set; }
        public string BillAddressKey { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCityName { get; set; }
        public string BillStateName { get; set; }
        public string BillStateCode { get; set; }
        public string BillPostalCode { get; set; }
        public string ShipAddressKey { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCityName { get; set; }
        public string ShipStateName { get; set; }
        public string ShipStateCode { get; set; }
        public string ShipPostalCode { get; set; }
        public string SaleRepID { get; set; }
        public DateTime? OrderDate { get; set; }
        public Decimal CrAmt { get; set; }
        public Decimal Amount { get; set; }
        public string OrdMemo { get; set; }
        public string PaymentTermKey { get; set; }
        public string TermName { get; set; }
        public string AuditMemo { get; set; }
        public string AuditConfirm { get; set; }


    }
}
