using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProductRepository.Entity
{
    public class DataContext: DbContext
    {
        public DataContext()
            : base("name =DefaultConnection")
        {

        }

        public virtual DbSet<Product> Products { get; set; }

    }
}
