using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotCafe.Database;

namespace TelegramBotCafe
{
    public static class MenuBasket
    {
        public static async Task<double> ViewBasket(this TelegramBotClient bot, long userId)
        {
            using (ContextDb database = new ContextDb())
            {
                var user = await database.Users
                    .Include(x => x.Cart)
                        .ThenInclude(c => c.Product)
                    .FirstAsync(x => x.TelegramId == userId);

                foreach (var item in user.Cart)
                {
                    await bot.SendTextMessageAsync(userId, item.Product.Name);
                }

                return user.Cart.Sum(x => x.Product.Price);
            }
        }
        public static IReplyMarkup MenuInlineBasket
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton($"Оплати замовлення!" )
                        {
                            CallbackData = "payment"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

    }
}
