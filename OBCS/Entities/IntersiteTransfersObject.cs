using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class IntersiteTransfersObject
    {
        public string StockSite { get; set; }
        public string DestSite { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
