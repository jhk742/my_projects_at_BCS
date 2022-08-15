using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class Product
    {
        public string ProductKey { get; set; }
        public string ProductID { get; set; }
        public string CdBranchCode { get; set; }
        public string CategoryKey { get; set; }
        public string GroupKey { get; set; }
        public string BrandKey { get; set; }
        public string TraderEntityKey { get; set; }
        public string ProductDesc { get; set; }
        public string PackSize { get; set; }
        public string ItemPack { get; set; }
        public string ItemSize { get; set; }
        public string ItemSizeUnit { get; set; }
        public string Unit { get; set; }
        public string CdPackDepttypeCode { get; set; }
        public string UnitPrice { get; set; }
        public string BottomPrice { get; set; }
        public string COGS { get; set; }
        public string RetailPrice { get; set; }
        public string IsPromo { get; set; }
        public string IsReplenish { get; set; }
        public string IsInActive { get; set; }
        public string PickBarCode { get; set; }
        public string UPCUnit { get; set; }
        public string UPCCase { get; set; }
        public string QtyOnhand { get; set; }
        public string QtyReserve { get; set; }
        public string LastRecDate { get; set; }
        public string GLOALL { get; set; }
        

    }
}
