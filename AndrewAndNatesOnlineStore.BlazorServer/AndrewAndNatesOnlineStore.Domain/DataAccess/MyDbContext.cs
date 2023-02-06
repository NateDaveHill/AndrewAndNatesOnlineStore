using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndrewAndNatesOnlineStore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AndrewAndNatesOnlineStore.Domain.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Shoppingcart> Shoppingcart { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB; Database=AndrewAndNatesOnlineStore;Integrated Security=True;");  

            //When I use my CodeFirt Db, ShoppingCart must be a List<Product> and if I use the one I created first, I must use a string for Shoppingcart

        }
    }
}
