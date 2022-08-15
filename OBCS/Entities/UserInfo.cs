using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBCS.Entities
{
    class UserInfo
    {

        public Int32 UserKey { get; set; } //[int] Not NULL,            
        public Int32 TraderEntityKey { get; set; } //[nvarchar](10) Not NULL,    
        public String CdBranchCode { get; set; }	//[int] Not NULL,    
        public String CdUserGroupCode { get; set; } ///[smallint] NULL,                  
                                                    //////
        ///
        public String PwCode { get; set; } //[char](3) Not NULL,    
        public String UserLevel { get; set; }	//[char](3) NULL,      
        public String IsInActive { get; set; }	//[char](3) NULL,   

        public String AppID { get; set; } ///[smallint] NULL,          
        public String ModId { get; set; } ///[smallint] NULL,  
        public DateTime? ModDate { get; set; }	//[char](3) NULL,              
        public String UserID { get; set; } //[nvarchar] Not NULL,    
        //public CdUserGroup CdUserGroup { get; set; }
        //public CdBranch CdBranch { get; set; }

        //[Include]
        //public Employee Employee { get; set; }
        ////public Employee Employee { get; set; }
    }
}
