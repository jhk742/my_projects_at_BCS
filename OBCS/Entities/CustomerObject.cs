using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class CustomerObject
    {
        public string CustomerBranch { get; set; }
        public string CustomerStatus { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSalesRep { get; set; }

        public DateTime CustomerSinceDate { get; set; }
        public string CustomerTaxID { get; set; }
        public string CustomerPaymentTerm { get; set; }
        public string CustomerBillingCompanyName { get; set; }
        public string CustomerPickingMemo { get; set; }
        public string CustomerMemo { get; set; }

        public string LabelType { get; set; }
        public Decimal CustomerNutMarkup { get; set; }
        public int NutMarkupPrintName { get; set; }
        public int NutMarkupByMarkup { get; set; }
        public int NutMarkupByCustomerPrice { get; set; }
        public int NutMarkupShowRetailPrice { get; set; }
        public int NutMarkupPrintAddress { get; set; }
        public int NutMarkupCustomLabel { get; set; }

        public string PCKStoreName { get; set; }
        public string PCKAddress1 { get; set; }
        public string PCKAddress2 { get; set; }
        public string PCKCity { get; set; }
        public string PCKState { get; set; }
        public string PCKZIP { get; set; }

        public int AcceptOrder { get; set; }

    }
}
