using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TelegramBotCafe.Database;

namespace TelegramBotCafe.Services
{
    public static class CartService
    {
        public static async Task Append(long userId, string productName)
        {
            using (ContextDb database = new ContextDb())
            {
                var user = await database.Users.FirstAsync(x=> x.TelegramId == userId);
                var product = await database.Products.FirstOrDefaultAsync(x => x.Name == productName);
                if(product != null)
                {
                    ProductsCart cart = new ProductsCart()
                    {
                        Product = product,
                        User = user,
                    };

                    database.UserCart.Add(cart);
                    database.SaveChanges();
                }
                
            }
        }
    }
}
