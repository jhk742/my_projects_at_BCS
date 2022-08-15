using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class ManualOrderProductObject
    {
        public string ProductKey { get; set; }
        public string ProductID { get; set; }
        public string ProductDesc { get; set; }
        public string PackSize { get; set; }
        public Decimal Onhand { get; set; }
        public Decimal LastPrice { get; set; }
        public Decimal ListPrice { get; set; }
        public Decimal BottomPrice { get; set; }
        public Decimal BasePrice { get; set; }
        public Decimal CustomPrice { get; set; }
        
    }
}
