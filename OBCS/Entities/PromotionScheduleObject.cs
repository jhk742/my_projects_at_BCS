using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class PromotionScheduleObject
    {
        public string BrandCode { get; set; }
        public string ProductID { get; set; }
        public string PromotionTypeCode { get; set; }
        public string PromotionBase { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AlertFromDate { get; set; }
        public DateTime AlertToDate { get; set; }
        public Decimal BasePrice { get; set; }
        public string Type { get; set; }
        public Decimal PromotionValue1 { get; set; }
        public string PromotionMethod1 { get; set; }
        public Decimal PromotionValue2 { get; set; }
        public string PromotionMethod2 { get; set; }
        public Decimal PromotionBuy { get; set; }
        public Decimal PromotionFree { get; set; }
        public Decimal NetPrice { get; set; }
        public string PromotionMemo { get; set; }
        public string Checked { get; set; }
        public string Status { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
