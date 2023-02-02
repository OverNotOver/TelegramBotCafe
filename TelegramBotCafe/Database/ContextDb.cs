using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe.Database
{
    public class ContextDb : DbContext
    {
        public DbSet<BotUsers> Users { get; set; }
        public DbSet<ProductsCart> UserCart { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ProductsOrder> OrderProducts { get; set; }
        public DbSet<ProductsCafe> Products { get; set; }
        


        public ContextDb()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=CoffeeDb;Trusted_Connection=True;");
        }
    }
}
