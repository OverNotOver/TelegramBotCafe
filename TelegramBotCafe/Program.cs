using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;

namespace TelegramBotCafe
{
    internal class Program
    {

        const string TOKEN = "5819847700:AAG_9gkNtLXkYQc_6QdaLsytndCt-3ozZLA";
        public static TelegramBotClient Over = new TelegramBotClient(TOKEN);
        static void Main(string[] args)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken cancel = source.Token;


            ReceiverOptions options = new ReceiverOptions() { AllowedUpdates = { } };

            Over.StartReceiving(BotTakeMassage, BotTakeError, options, cancel);

            Console.ReadKey();

        }


        static async Task BotTakeMassage(ITelegramBotClient botClient, Update update, CancellationToken token)
        {

            Message message = update.Message;

            if (update.Type == UpdateType.Message)
            {
                if (message.Type == MessageType.Text)
                {
                    await GetStartBot(message);

                }
                else if (message.Type == MessageType.Location)
                {
                    await GetLocation(message);
                }
                else
                {
                    await Over.SendTextMessageAsync(message.Chat.Id, "Я не був створений для цього",
                        replyMarkup: MenuModel.MainMenuUser);
                }
            }
            else if (update.Type == UpdateType.CallbackQuery)
            {

                await GetCallback(update.CallbackQuery, message);
            }

        }

        static async Task GetStartBot(Message message)
        {
            string mess = message.Text.ToLower();
            if (mess == "/start")
            {
                await GetJoinToDataBase(message);
                await SelectUserPole(message);
            }
            else if (mess == "/thx")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Ваша підтримка приємна для нас. Донат?");
            }
            else if (mess == "меню")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Продукти",
                        replyMarkup: MenuModel.ProductMenu);
            }
            else if (mess == "👈 головне меню")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Головне меню",
                        replyMarkup: MenuModel.MainMenuUser);
            }
            else if (mess == "кава/чай/какао")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Можемо запропонувати",
                    replyMarkup: MenuInlineDrinks.Drinks);
            }
            else if (mess == "контакти")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "м. Суми\r\n\r\n вул. Харківська, 5/1 (Sushi&Pizza)\r\n\r\nЗамовлення на сайті приймаються\r\n Пн - Чт  9:00 - 20:00\r\n Пт - Нд  9:00 - 21:00\r\nбез перерви та вихідних\r\n\r\n +38 (050) 556-44-20",
                   replyMarkup: MenuModel.MainMenuUser);
            }
            else if (mess == "мій профіль")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, $"Вітаю у вашому профелі {message.From.FirstName}, тут вся инфа про аккаунт!",
                    replyMarkup: MenuModel.MainMenuUser);

            }
            else if (mess == "щось до кави")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Що до кави бажаєте???",
                   replyMarkup: MenuInlineFoods.FoodsForCoffee);
            }
            else if (mess == "точки")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Хуйочки :-)",
                   replyMarkup: MenuModel.MainMenuUser);
            }
        }
        static async Task GetCallback(CallbackQuery query, Message message)
        {
            await Over.DeleteMessageAsync(query.From.Id, query.Message.MessageId);

            await GetMenuDrinks(query, message);
            await GetAmericano(query, message);
            await GetCapuchino(query, message);
            await GetLatte(query, message);
            await GetMenuFoods(query);


            #region
            //string mess = query.Data;
            ////string mess2 = message.Text.ToLower();

            //if (mess == "coffee")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
            //        replyMarkup: MenuInline.DrinksCoffee);
            //}
            //else if (mess == "tea")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
            //        replyMarkup: MenuInline.DrinksTea);
            //}
            //else if (mess == "drinks")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
            //        replyMarkup: MenuInline.DrinksDrinks);
            //}
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

            //конец меню, начало подменю по товарам из меню


            //латте:
            //else if (mess == "latte")
            //{
            //    await Over.SendPhotoAsync(query.From.Id, photo: "https://kofella.net/images/stories/vseokofe/chem-otlichaetsya-latte-ot-kapuchino-latte.jpg",
            //        "Латте - кавовий напій з піни, молока та кави еспресо", replyMarkup: ProductsInlineInfo.LatteInfo
            //        );
            //}
            //else if (mess == "latte350")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.LatteInfoBuy);


            //}
            //else if (mess == "latte500")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.LatteInfoBuy);
            //}


            //капучино:

            //else if (mess == "capuchino")
            //{
            //    await Over.SendPhotoAsync(query.From.Id, photo: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-c6hbRCxugHtwwRwPAhGIxjTGgFJiHzgWcS7BHu3jDU19l11_8Xg5gl5nH4iyOJ7cMiY&usqp=CAU",
            //        "Капучино - кавовий напій основі еспресо з додаванням збитого парою молока, з гармонійним балансом насиченого солодкого смаку молока та еспресо", replyMarkup: ProductsInlineInfo.CapuchinoInfo
            //        );
            //}
            //else if (mess == "capuchi300")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.CapuchinoInfoBuy);


            //}
            //else if (mess == "capuchi450")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.CapuchinoInfoBuy);
            //}

            //американо:

            //else if (mess == "americano")
            //{
            //    await Over.SendPhotoAsync(query.From.Id, photo: "http://dvazajci.com/wp-content/uploads/2021/05/photo-960x608.jpg",
            //        "Американо (кава по-американськи, регулярна кава) отримала свою назву, оскільки була широко популярною в Північній Америці", replyMarkup: ProductsInlineInfo.AmericanoInfo
            //        );
            //}
            //else if (mess == "americano150")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.AmericanoInfoBuy);
            //}
            //else if (mess == "americano220")
            //{
            //    await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.AmericanoInfoBuy);
            //}

            #endregion

        }
        public static async Task GetMenuDrinks(CallbackQuery query, Message message)
        {
            string mess = query.Data;

            if (mess == "coffee")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
                    replyMarkup: MenuInlineDrinks.DrinksCoffee);
            }
            else if (mess == "tea")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
                    replyMarkup: MenuInlineDrinks.DrinksTea);
            }
            else if (mess == "drinks")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
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
        public static async Task GetMenuFoods(CallbackQuery query)
        {
            string mess = query.Data;

            if (mess == "cruasan")
            {
                await Over.SendPhotoAsync(chatId: query.From.Id, photo: "https://i.lefood.menu/wp-content/uploads/w_images/2022/12/recept-51199-472x315.webp", "Круасан инфо, ккал 200, ціна 100грн", replyMarkup: MenuInlineFoods.Cruassans);
            }
            else if (mess == "makaron")
            {
                await Over.SendPhotoAsync(chatId: query.From.Id, photo: "https://tutknow.ru/uploads/posts/2020-06/thumbs/1591119891_1.jpg", "макарон инфо, ккал 200, ціна 100грн", replyMarkup: MenuInlineFoods.Macarons);
            }
            else if (mess == "ecler")
            {
                await Over.SendPhotoAsync(chatId: query.From.Id, photo: "https://upload.wikimedia.org/wikipedia/commons/7/7a/Ecler.jpg", "еклер инфо, ккал 200, ціна 100грн", replyMarkup: MenuInlineFoods.Eclers);
            }



        }
        public static async Task GetAmericano(CallbackQuery query, Message message)
        {
            //await Over.DeleteMessageAsync(query.From.Id, query.Message.MessageId);
            string mess = query.Data;

            if (mess == "americano")
            {
                await Over.SendPhotoAsync(query.From.Id, photo: "http://dvazajci.com/wp-content/uploads/2021/05/photo-960x608.jpg",
                    "Американо (кава по-американськи, регулярна кава) отримала свою назву, оскільки була широко популярною в Північній Америці", replyMarkup: ProductsInlineInfo.AmericanoInfo
                    );
            }
            else if (mess == "americano150")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.AmericanoInfoBuy);


            }
            else if (mess == "americano220")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.AmericanoInfoBuy);
            }

        }
        public static async Task GetCapuchino(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "capuchino")
            {
                await Over.SendPhotoAsync(query.From.Id, photo: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-c6hbRCxugHtwwRwPAhGIxjTGgFJiHzgWcS7BHu3jDU19l11_8Xg5gl5nH4iyOJ7cMiY&usqp=CAU",
                    "Капучино - кавовий напій основі еспресо з додаванням збитого парою молока, з гармонійним балансом насиченого солодкого смаку молока та еспресо", replyMarkup: ProductsInlineInfo.CapuchinoInfo
                    );
            }
            else if (mess == "capuchi300")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.CapuchinoInfoBuy);


            }
            else if (mess == "capuchi450")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.CapuchinoInfoBuy);
            }

        }
        public static async Task GetLatte(CallbackQuery query, Message message)
        {
            string mess = query.Data;
            if (mess == "latte")
            {
                await Over.SendPhotoAsync(query.From.Id, photo: "https://kofella.net/images/stories/vseokofe/chem-otlichaetsya-latte-ot-kapuchino-latte.jpg",
                    "Латте - кавовий напій з піни, молока та кави еспресо", replyMarkup: ProductsInlineInfo.LatteInfo
                    );
            }
            else if (mess == "latte350")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.LatteInfoBuy);


            }
            else if (mess == "latte500")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: ProductsInlineInfo.LatteInfoBuy);
            }

        }
        public static async Task GetJoinToDataBase(Message message)
        {
            if(message != null)
            {
                string mess2 = message.Text.ToLower();
                if (mess2 == "/start")
                {
                    await Over.SendTextMessageAsync(message.From.Id, "Проверка БД");
                    using (ContextDb contextDb = new ContextDb())
                    {
                        if (contextDb.Users.FirstOrDefault(user => user.TelegramId == message.From.Id) == null)
                        {
                            BotUsers botUser = new BotUsers()
                            {
                                TelegramId = message.From.Id,
                                UserName = message.From.Username,
                                UserPole = "User"
                            };
                            await contextDb.Users.AddAsync(botUser);
                            await contextDb.SaveChangesAsync();
                            await Over.SendTextMessageAsync(message.From.Id, "Запить юзера в базу успешна!");
                        }
                        await Over.SendTextMessageAsync(message.From.Id, "Юзер уже в базе");
                    }

                }
            }
        }
        public static async Task SelectUserPole(Message message)
        {
            await Over.SendTextMessageAsync(message.From.Id, "Соединение... проверка на роль");
            using (ContextDb contextDb = new ContextDb())
            {

                var persom = contextDb.Users
                    .FirstOrDefault(per => per.TelegramId == message.From.Id);
                if (persom.UserPole == Role.Admin)
                {
                    await Over.SendTextMessageAsync(message.From.Id, "Админ тут",
                        replyMarkup: MenuModel.MainMenuAdmin);
                }
                else
                {
                    await Over.SendPhotoAsync
                  (
                      chatId: message.Chat.Id,
                      photo: "https://ae01.alicdn.com/kf/Hf069064de2164e3ba3871b8f8b8dfdc14/Coffee-Shop-Sign-Premium-Coffee-Sign-Mug-Logo-Cafe-Decor-Highest-Quality-Wall-Cup-Decal-Sticker.jpg_Q90.jpg_.webp",
                      message.Text = $"Вітаю {message.From.FirstName} в нашому кафе. Можеш по пить кофе або подивитися на сиськи!",
                      replyMarkup: MenuModel.MainMenuUser
                  );
                }

            }
        }
        static async Task GetLocation(Message message)
        {
            await Over.SendTextMessageAsync(message.Chat.Id, "Локація отримана, дурка виїхала",
                        replyMarkup: MenuModel.MainMenuUser);
        }
        static async Task BotTakeError(ITelegramBotClient botClient, Exception ex, CancellationToken token)
        {

        }






    }
}