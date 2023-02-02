using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe.Database
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime DateTimeOrder { get; set; }

        public BotUsers UserOrder { get; set; }
        public List<ProductsOrder> Products { get; set; }
        public bool Active { get; set; }


    }
}
