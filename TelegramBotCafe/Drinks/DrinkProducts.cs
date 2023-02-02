using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotCafe.Database;
using TelegramBotCafe.Services;

namespace TelegramBotCafe.Drinks
{
   
    public static class DrinkProducts
    {
        public static async Task GetMenuDrinks(CallbackQuery query, Message message)
        {
            string mess = query.Data;

            if (mess == "coffee")
            {
                await Program.Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
                    replyMarkup: MenuInlineDrinks.DrinksCoffee);
            }
            else if (mess == "tea")
            {
                await Program.Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
                    replyMarkup: MenuInlineDrinks.DrinksTea);
            }
            else if (mess == "drinks")
            {
                await Program.Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
                    replyMarkup: MenuInlineDrinks.DrinksDrinks);
            }
            //else if (mess == "bear")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Охоче вам пропонуємо",
            //            replyMarkup: MenuInline.DrinksBear);
            //}
            //else if (mess == "koktels")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
            //        replyMarkup: MenuInline.DrinksKoktels);
            //}
            //else if (mess == "other")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
            //        replyMarkup: MenuInline.DrinksOther);
            //}

        }

        public static async Task GetAmericano(CallbackQuery query, Message message)
        {
            string mess = query.Data;

            if (mess == "americano")
            {
                await Program.Over.SendPhotoAsync(query.From.Id, photo: "http://dvazajci.com/wp-content/uploads/2021/05/photo-960x608.jpg",
                    "Американо (кава по-американськи, регулярна кава) отримала свою назву, оскільки була широко популярною в Північній Америці", replyMarkup: DrinkProductsInlineInfo.AmericanoInfo
                    );
            }
            else if (mess == "Американо(150)" || mess == "Американо(220)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }
        }
        public static async Task GetCapuchino(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "capuchino")
            {
                await Program.Over.SendPhotoAsync(query.From.Id, photo: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-c6hbRCxugHtwwRwPAhGIxjTGgFJiHzgWcS7BHu3jDU19l11_8Xg5gl5nH4iyOJ7cMiY&usqp=CAU",
                    "Капучино - кавовий напій основі еспресо з додаванням збитого парою молока, з гармонійним балансом насиченого солодкого смаку молока та еспресо", replyMarkup: DrinkProductsInlineInfo.CapuchinoInfo
                    );
            }
            else if (mess == "Капучино(300)" || mess == "Капучино(450)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }

        }
        public static async Task GetLatte(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "latte")
            {
                await Program.Over.SendPhotoAsync(query.From.Id, photo: "https://kofella.net/images/stories/vseokofe/chem-otlichaetsya-latte-ot-kapuchino-latte.jpg",
                    "Латте - кавовий напій з піни, молока та кави еспресо", replyMarkup: DrinkProductsInlineInfo.LatteInfo
                    );
            }
            else if (mess == "Латте(300)" || mess == "Латте(500)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }
        }
        
        public static async Task MenuOrPay(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "back_to_main")
            {
                await Program.Over.SendTextMessageAsync(query.From.Id,"Меню", replyMarkup: MenuModel.MainMenuUser);
            }
            else if (mess == "payment")
            {
                await OrderService.Create(query.From.Id);
                string href = await PaymentService.CreatePay(query.From.Id);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Ваша квитанція до оплати: " + href);


            }
        }
    }
}
