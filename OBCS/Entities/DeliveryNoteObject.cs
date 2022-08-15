using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class DeliveryNoteObject
    {
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string CustomerID { get; set; }
        public string ShipTo { get; set; }
        public string BillTo { get; set; }
        public string RouteNumber { get; set; }
        public string RouteStop { get; set; }
        public string Term { get; set; }
        public string SalesPerson { get; set; }
        public string SalesPersonMobile { get; set; }
        public Decimal CreditAmount { get; set; }
        public Decimal TotalBox { get; set; }
        public Decimal ABox { get; set; }
        public Decimal BBox { get; set; }
        public Decimal CBox { get; set; }
        public Decimal DBox { get; set; }
        public Decimal EBox { get; set; }
        public Decimal FBox { get; set; }
        public Decimal ReturnAmount { get; set; }
        public string DeliveryNumber { get; set; }
        public Decimal AR { get; set; }
        public Decimal TotalAmount { get; set; }
    }
}
