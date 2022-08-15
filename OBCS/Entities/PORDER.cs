using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class PORDER
    {
        public string RECNumber { get; set; }
        public string PORDERNumber { get; set; }
        public string Supplier { get; set; }
        public string SupplierDocNo { get; set; }
        public Decimal SupplierDocAmount { get; set; }
        public Decimal ReceiptAmount { get; set; }
        public Decimal Diff { get; set; }
        public Decimal InvoiceAmount { get; set; }
        public string Memo { get; set; }
        public string ProductBCS { get; set; }
        public string ProductSupplier { get; set; }
        public Decimal OrderQty { get; set; }
        public Decimal Qty { get; set; }
        public Decimal STKQty { get; set; }
        public string Description { get; set; }
        public string PackSize { get; set; }
        public Decimal GrossPrice { get; set; }
        public Decimal EDLP { get; set; }
        public Decimal EDLPP { get; set; }
        public Decimal TermPromo { get; set; }
        public Decimal TermPromoP { get; set; }
        public Decimal NetPrice { get; set; }
        public Decimal OrderAmount { get; set; }
        public Decimal GRAmount { get; set; }
        public string Unit { get; set; }
        public DateTime ExpectedRcptDate { get; set; }
        public string BilledBySupplier { get; set; }
        public int Line { get; set; }
        public string Location { get; set; }
        public Decimal InnerCase { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ReceivingSite { get; set; }
        public DateTime ReceivingDate { get; set; }
        public string ProductStatus { get; set; }
        public int ROWID { get; set; }

    }
}
