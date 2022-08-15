using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class OrderDetail2
    {
        public string OrderID { get; set; }
        public string OrderDetailKey { get; set; }
        public string ProductID { get; set; }
        public string ProductKey { get; set; }
        public Decimal OrderQty { get; set; }
        public Decimal Price { get; set; }
        public Decimal Amount { get; set; }
        public string ReturnFlag { get; set; }
        public string Remark { get; set; }
        public string CreateUserID { get; set; }
        public DateTime? CreateTime { get; set; }
        public string ModUserID { get; set; }
        public DateTime? ModTime { get; set; }
        public string Status { get; set; }
        public string PickingNumber { get; set; }
        public string PickingCategory { get; set; }
        public Decimal PackedQty { get; set; }
    }
}
