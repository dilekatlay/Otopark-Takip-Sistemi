using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark2
{
    public class ProductDal
    {
        public List<table> GetAll()
        {
            using (EtradeContext context = new EtradeContext())
            {
                return context.table.ToList();
            }
        }

        public void Add(table table)
        {
            using (EtradeContext context = new EtradeContext())
            {
                context.table.Add(table);
                context.SaveChanges();
            }

        }

        public void Update(table table)
        {
            using (EtradeContext context = new EtradeContext())
            {
                var entity = context.Entry(table);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void Delete(table table)
        {
            using (EtradeContext context = new EtradeContext())
            {
                var entity = context.Entry(table);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }

        }
    }
}
