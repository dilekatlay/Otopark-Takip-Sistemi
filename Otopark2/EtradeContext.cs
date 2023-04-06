using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark2
{
    public class EtradeContext:DbContext
    {
        public  DbSet<table> table { get; set; }
    }
}
