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
    public static class OrderService
    {
        public static async Task Create(long userId)
        {
            using (ContextDb database = new ContextDb())
            {
                var user = await database.Users
                    .Include(x => x.Cart)
                        .ThenInclude(c => c.Product)
                    .FirstAsync(x=> x.TelegramId == userId);

                Orders order = new Orders()
                {
                    DateTimeOrder = DateTime.Now,
                    UserOrder = user,
                    Products = new List<ProductsOrder>(),
                    Active = true
                };

                foreach (var cartItem in user.Cart)
                {
                    order.Products.Add(new ProductsOrder()
                    {
                        Product = cartItem.Product
                    });
                    database.UserCart.Remove(cartItem);
                }

                


                database.Orders.Add(order);
                database.SaveChanges(); 
            }
        }
    }
}
