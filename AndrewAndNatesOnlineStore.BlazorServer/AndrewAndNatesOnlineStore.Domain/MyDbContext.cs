using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AndrewAndNatesOnlineStore.Domain
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer>? Customer { get; set; }
        public DbSet<Product>? Product { get; set; }
        public DbSet<Shoppingcart>? Shoppingcart { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
