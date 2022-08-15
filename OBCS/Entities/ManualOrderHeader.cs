using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class ManualOrderHeader
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string OrderMemo { get; set; }
        public Decimal CreditAmount { get; set; }
    }
}
