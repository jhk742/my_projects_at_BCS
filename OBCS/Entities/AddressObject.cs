using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class AddressObject
    {
        public string ID { get; set; }
        public string ROWID { get; set; }
        public string AddressCode { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressEmail { get; set; }
        public string AddressTel1 { get; set; }
        public string AddressTel2 { get; set; }
        public string AddressFax { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public string Address1bill { get; set; }
        public string Address2bill { get; set; }
        public string AddressCitybill { get; set; }
        public string AddressStatebill { get; set; }
        public string AddressPostalCodebill { get; set; }
        public string AddressEmailbill { get; set; }
        public string AddressTel1bill { get; set; }
        public string AddressTel2bill { get; set; }
        public string AddressFaxbill { get; set; }
        public string Latitudebill { get; set; }
        public string Longitudebill { get; set; }
    }
}
