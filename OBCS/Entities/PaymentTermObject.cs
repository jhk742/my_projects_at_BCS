using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class PaymentTermObject
    {
        public string PaymentTerm { get; set; }
        public string Description { get; set; }
        public decimal DCPercentage { get; set; }
        public decimal DCDays { get; set; }
        public decimal NetDaysToPay { get; set; }
        public String Status { get; set; }
    }
}
