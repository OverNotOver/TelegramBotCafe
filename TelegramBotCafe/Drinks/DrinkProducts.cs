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

        public static async Task GetKakao(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "kakao")
            {
                await Program.Over.SendPhotoAsync(query.From.Id, photo: "https://i.obozrevatel.com/food/recipemain/2019/10/28/screenshot8.jpg?size=636x424",
                    "Какао — напій, до складу якого обов'язково входить какао, а також молоко (або вода) і цукор. Напій зазвичай безалкогольний", replyMarkup: DrinkProductsInlineInfo.KakaoInfo
                    );
            }
            else if (mess == "Какао(400)" || mess == "Какао(500)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }
        }


        public static async Task GetGreenTea(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "green_tea")
            {
                await Program.Over.SendPhotoAsync(query.From.Id, photo: "https://i.apteka24.ua/blog/69cd19c7-b413-493e-bf41-5fb3ec027186-large.jpeg",
                    "Зелений чай — ґатунок чаю, який досягається такою обробкою чайного листя: зав'ялювання + часткова сушка + скручування + досушування, також подрібнення (наприклад, у Японії). ", replyMarkup: DrinkProductsInlineInfo.TeaGreenInfo
                    );
            }
            else if (mess == "Зелений_чай(300)" || mess == "Зелений_чай(500)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }
        }

        public static async Task GetBlackTea(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "black_tea")
            {
                await Program.Over.SendPhotoAsync(query.From.Id, photo: "https://np.pl.ua/wp-content/uploads/2018/12/shutterstock_519547102.jpg",
                    "Чорний чай — вид чаю, який отримують шляхом повного або майже повного окиснення листа чайного куща. Китайські чорні чаї в Китаї називають червоними або багряними", replyMarkup: DrinkProductsInlineInfo.TeaBlackInfo
                    );
            }
            else if (mess == "Чорний_чай(300)" || mess == "Чорний_чай(500)")
            {
                await CartService.Append(query.From.Id, mess);
                await Program.Over.SendTextMessageAsync(query.From.Id, "Бажаєте продовжити?", replyMarkup: DrinkProductsInlineInfo.BackOrPay);
            }
        }

        public static async Task GetFruitTea(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "fruit_tea")
            {
                await Program.Over.SendPhotoAsync(query.From.Id, photo: "https://smak.ua/i/60/23/7/60237/fbdad65d47b0cb5704b092903a7ffc3b-resize_crop_1Xquality_100Xallow_enlarge_0Xw_1200Xh_630.jpg",
                    "Фруктовий чай - суміш різних видів обсмаженої рослинної сировини з додаванням рафінадної патоки та фруктових есенцій.", replyMarkup: DrinkProductsInlineInfo.TeaGreenInfo
                    );
            }
            else if (mess == "Фруктовий_чай(300)" || mess == "Фруктовий_чай(500)")
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
                await Program.Over.SendTextMessageAsync(query.From.Id,"Меню", replyMarkup: MenuModel.ProductMenu);
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
