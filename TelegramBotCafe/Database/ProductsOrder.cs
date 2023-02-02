using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe.Database
{
    public class ProductsOrder
    {
        [Key]
        public int Id { get; set; }
        public Orders Order { get; set; }
        public int ProductId { get; set; }
        public ProductsCafe Product { get; set; }
    }
}
