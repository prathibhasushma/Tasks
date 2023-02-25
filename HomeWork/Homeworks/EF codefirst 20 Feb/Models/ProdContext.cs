using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_codefirst_20_Feb.Models
{
    internal class ProdContext : DbContext
    {
        private const string connectionstring = " Server = (LocalDB)\\MSSQLLocalDB ; Database = ProdCore ; Trusted_Connection = True; ";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBatch> ProductBatches { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> standards { get; set; }

    }
}
