using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBotCafe.Drinks;
using TelegramBotCafe.Services;

namespace TelegramBotCafe.Foods
{
    public static class FoodProducts
    {
        public static async Task GetMenuFoods(CallbackQuery query)
        {
            
            string mess = query.Data;

            if (mess == "cruasan")
            {
                await Program.Over.SendPhotoAsync(chatId: query.From.Id, photo: "https://i.lefood.menu/wp-content/uploads/w_images/2022/12/recept-51199-472x315.webp", "Круасан инфо, ккал 200, ціна 100грн", replyMarkup: MenuInlineFoods.Cruassans);
            }
            else if (mess == "makaron")
            {
                await Program.Over.SendPhotoAsync(chatId: query.From.Id, photo: "https://tutknow.ru/uploads/posts/2020-06/thumbs/1591119891_1.jpg", "макарон инфо, ккал 200, ціна 60грн", replyMarkup: MenuInlineFoods.Macarons);
            }
            else if (mess == "ecler")
            {
                await Program.Over.SendPhotoAsync(chatId: query.From.Id, photo: "https://upload.wikimedia.org/wikipedia/commons/7/7a/Ecler.jpg", "еклер инфо, ккал 200, ціна 80грн", replyMarkup: MenuInlineFoods.Eclers);
            }
        }


        public static async Task GetFood(CallbackQuery query, Message message)
        {
            string mess = query.Data;

            if (mess == "Круассан(Шоколад)" || mess == "Круассан(Малина)" || mess == "Круассан(Фісташка)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }
            else if (mess == "Макарон(Лохина)" || mess == "Макарон(Полуниця)" || mess == "Макарон(Черешня)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }
            else if (mess == "Еклер(Ананас)" || mess == "Еклер(Полуниця)" || mess == "Еклер(Банан)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }

        }

    }
}
