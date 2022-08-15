using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class DeliveryManifest
    {
        public Decimal Bill100 { get; set; }
        public Decimal Bill50 { get; set; }
        public Decimal Bill20 { get; set; }
        public Decimal Bill10 { get; set; }
        public Decimal Bill5 { get; set; }
        public Decimal Bill2 { get; set; }
        public Decimal Bill1 { get; set; }
        public Decimal Coins { get; set; }
        public Decimal Park { get; set; }
        public Decimal Gas { get; set; }
        public Decimal Toll { get; set; }
        public Decimal Misc { get; set; }
    }
}
