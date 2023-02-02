using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe.Database
{
    public class BotUsers
    {
        public Guid Id { get; set; }
        public long TelegramId { get; set; }
        public string UserName { get; set; }
        public Role UserPole { get; set; }
        public List<ProductsCart> Cart { get; set; }
        public List<Orders> Orders { get; set; }
    }

    public enum Role
    {
        User,
        Admin
    }

}
