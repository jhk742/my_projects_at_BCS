using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class Order2
    {
        public string id { get; set; }
        public string iPadOrderID { get; set; }
        public string OrderID { get; set; }
        public string DeliveryNumber { get; set; }
        public string CreditAmount { get; set; }
        public DateTime? OrderDate { get; set; }
        public string SaleRep { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillState { get; set; }
        public string BillZip { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string Branch { get; set; }
        public string PaymentTermKey { get; set; }
        //public string TermName { get; set; }
        public string OrderStatus { get; set; }
        public string CreateUserID { get; set; }
        public DateTime? CreateTime { get; set; }
        public string LastModUserID { get; set; }
        public DateTime? LastModTime { get; set; }
        public string OrderMemo { get; set; }
        public int RouteNumber { get; set; }
        public string RouteStop { get; set; }
        public Decimal Amount { get; set; }
        public string AuditMemo { get; set; }
        public string AuditConfirm { get; set; }
    }
}
