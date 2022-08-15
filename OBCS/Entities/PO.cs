using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OBCS.Entities
{
    public class PO
    {
        public Int32 POKey { get; set; }//[int] NOT NULL,
        public String CdBranchCode { get; set; }//[char](3) NULL,
        public Int32 PONo { get; set; }//[int] NULL,
        public String CdInventoryIOCode { get; set; }//[char](6) NULL,
        public String CtPOTypeCode { get; set; }//[char](3) NULL,
        public Int32 TraderEntityKey { get; set; }//[int] NULL,
        public String CdShipViaCode { get; set; }//[char](3) NULL,
        public String CtShipMethod { get; set; }//[char](2) NULL,
        public Int16 PaymentTermKey { get; set; }//[smallint] NULL,
        public Int32 VendorBrokerKey { get; set; }//[int] NULL,
        public Int32 OrderContactKey { get; set; }//[int] NULL,
        public String CtPOStatus { get; set; }//[char](3) NULL,
        public String CdLocation { get; set; }//[char](3) NULL,
        public DateTime? OrderDate { get; set; }//[smalldatetime] NULL,
        public DateTime? OrderSubmitDate { get; set; }//[smalldatetime] NULL,
        public String ExpectedDevDate { get; set; }//[smalldatetime] NULL,
        public DateTime? RecevingDate { get; set; }//[smalldatetime] NULL,
        public Boolean? IsConfirmed { get; set; }//[bit] NULL,
        public String ConfirmedUser { get; set; }//[varchar](50) NULL,
        public String ConfirmedVendor { get; set; }//[varchar](50) NULL,
        public String POMemo { get; set; }//[nchar](10) NULL,
        public String RecevingMemo { get; set; }//[nchar](10) NULL,
        //public Byte[] RowVersion { get; set; }//[timestamp] NULL,
        //public String HistTermName { get; set; } // [nvarchar](50) NULL,
        //public String HistSalesPerson { get; set; } // [nvarchar](50) NULL,
        //public String HistVendorID { get; set; } // [varchar](20) NULL,
        //public String HistVendorName { get; set; } // [nvarchar](50) NULL,  
        //1052
        public string PalletGtCode { get; set; } //[nvarchar](8)
        public Int32? BillAddrKey { get; set; } // [int] NULL,
        public Int32? ShipAddrKey { get; set; } // [int] NULL,    
        public DateTime? AddDate { get; set; }//[smalldatetime] NULL,
        public String AddUser { get; set; }//[smalldatetime] NULL,
    }

    public class PODetail
    {
        public Int32 PODetailKey { get; set; }      //[int] NOT NULL,                          
        public Int32 POKey { get; set; }            //[int] NULL,                              
        public Int32 ProductKey { get; set; }//[int] NULL,                              
        public Decimal CsOrdQty { get; set; }//[decimal](9, 2) NULL,                    
        public Decimal BxOrdQty { get; set; }//[decimal](9, 2) NULL,                    
        public Decimal CsRecQty { get; set; }//[decimal](9, 2) NULL,                    
        public Decimal BxRecQty { get; set; }//[decimal](9, 2) NULL,                    
        public Decimal ListPr { get; set; }//[smallmoney] NULL,                       
        public Decimal ListAmt { get; set; }//[smallmoney] NULL,                       
        public Decimal DcRate1 { get; set; }//[decimal](9, 2) NULL,                    
        public String DcKind1 { get; set; }//[char](1) NULL,                          
        public Decimal DcRate2 { get; set; }//[decimal](9, 2) NULL,                    
        public String DcKind2 { get; set; }//[char](1) NULL,                          
        public Decimal NetPr { get; set; }//[smallint] NULL,    //1052 int16 -> Decimal
        public Decimal Amount { get; set; }//[smallmoney] NULL,                       
        public String ExpireDate { get; set; }//[smalldatetime] NULL,                    
        public Decimal InnerQty { get; set; }//[decimal](9, 2) NULL,                    

        //1052
        public String CdLocation { get; set; }  // [char](3) NOT NULL, 

        // ▼ ADD 2013/03/27 Ashley Choi   ▼                                                                                                                                                  
        public String FlgRemark { get; set; }//[char](3) NULL,
        // ▲ ADD 2013/03/27 Ashley Choi  ▲      
        
        public PO PO { get; set; }

    }
}
