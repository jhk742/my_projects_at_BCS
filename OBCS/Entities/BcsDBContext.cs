using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace OBCS.Entities
{
    class BcsDBContext : DbContext
    {
        public BcsDBContext()
        {

        }
        public DbSet<PO> POs { get; set; }
    }
}
