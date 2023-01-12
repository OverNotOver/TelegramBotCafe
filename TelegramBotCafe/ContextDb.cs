using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe
{
    public class ContextDb : DbContext
    {
        public DbSet<BotUsers> Users { get; set; }
        public ContextDb()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=TelegramCoffee;Trusted_Connection=True;");
        }
    }
}
