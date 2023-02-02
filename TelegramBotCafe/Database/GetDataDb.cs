using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe.Database
{
    public static class GetDataDb
    {
        public static void GetInfodb()
        {
            using(ContextDb contextDb = new ContextDb())
            {
                var prods = contextDb.Products;

                foreach (var item in prods)
                {
                    Console.WriteLine(item.Name + " " + item.Price);
                }
            }

        }
    }
}
