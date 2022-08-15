using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class Employee
    {
        public int TraderEntityKey { get; set; }		//[int] NOT NULL,           
        public string EmployeeID { get; set; }//[varchar](10) NOT NULL,           
        public string CdBranchCode { get; set; }	//char(3) NOT NULL,         
        public int DepartmentKey { get; set; }//[int] NOT NULL,           
        public int TitleKey { get; set; }//[int]NOT NULL,           
        public bool IsActive { get; set; } //[bit] NOT NULL,                  
        public string FirstName { get; set; }//[nvarchar](20) NULL,          
        public string LastName { get; set; } //[nvarchar](20) NULL,          
        public string AidName { get; set; }  //[nvarchar](20) NULL,
        public string DriverID { get; set; } //[varchar](15) NULL,           
        public string SSNo { get; set; }	 //[varchar](10) NULL,         
        public DateTime? DOB { get; set; }//[smalldatetime] NULL,         
        public DateTime? HireDate { get; set; }//[smalldatetime] NULL,         
        public DateTime? LastDate { get; set; }//[smalldatetime] NULL,         
        //[RegularExpression (@"(?<user>[^@]+)@(?<host>.+)")]
        public string Email { get; set; }//[varchar](30) NULL,           
        public string PhoneHome { get; set; }//[varchar](15) NULL,           
        public string PhoneMobile { get; set; }//[varchar](15) NULL,          
        public string PhoneAlt { get; set; }//[varchar](15) NULL,          
        public string PhotoPath { get; set; }//[varchar](50) NULL,          
        public int OldKey { get; set; }//[int] NULL,                  
        public DateTime? ModDate { get; set; }//[datetime] NULL,
        public string DepartmentName { get; set; }//[varchar](50) NULL,  
        public string TitleName { get; set; }//[varchar](50) NULL,  
        public string Memo { get; set; }
        public string BranchName { get; set; }


        //[Include]
        //public TraderEntity TraderEntity { get; set; }

        //[Include]
        //public CdBranch CdBranch { get; set; }

        //[Include]
        //public Department Department { get; set; }

        //[Include]
        //public Title Title { get; set; }
    }
}
