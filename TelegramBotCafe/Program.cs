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
                        replyMarkup: MenuModel.MainMenu);
                }
            }
            else if (update.Type == UpdateType.CallbackQuery)
            {
                //await GetJoinToDataBase2(message, query);
                await GetCallback(update.CallbackQuery, message);
            }

        }

        static async Task GetStartBot(Message message)
        {
            string mess = message.Text.ToLower();
            if (mess == "/start")
            {
                await GetJoinToDataBase2(message);
                await Over.SendPhotoAsync
                    (
                        chatId: message.Chat.Id, 
                        photo: "https://ae01.alicdn.com/kf/Hf069064de2164e3ba3871b8f8b8dfdc14/Coffee-Shop-Sign-Premium-Coffee-Sign-Mug-Logo-Cafe-Decor-Highest-Quality-Wall-Cup-Decal-Sticker.jpg_Q90.jpg_.webp",
                        message.Text = $"Вітаю {message.From.FirstName} в нашому кафе. Можеш по пить кофе або подивитися на сиськи!",
                        replyMarkup: MenuModel.MainMenu
                    );


            }
            else if (mess == "меню")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Продукти",
                        replyMarkup: MenuModel.ProductMenu);
            }
            else if (mess == "👈 головне меню")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Головне меню",
                        replyMarkup: MenuModel.MainMenu);
            }
            else if (mess == "напої")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Можемо запропонувати",
                    replyMarkup: MenuInline.Drinks);
            }
            else if (mess == "контакти")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "м. Суми\r\n\r\n вул. Харківська, 5/1 (Sushi&Pizza)\r\n\r\nЗамовлення на сайті приймаються\r\n Пн - Чт  9:00 - 20:00\r\n Пт - Нд  9:00 - 21:00\r\nбез перерви та вихідних\r\n\r\n +38 (050) 556-44-20",
                   replyMarkup: MenuModel.MainMenu);
            }
            else if (mess == "доставка")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Введіть адрес доставки або вставте геолакацію",
                    replyMarkup: MenuModel.MainMenu);

            }
            else if (mess == "авторизація")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Якщо ви зареєстровані - авторизуйтесь, ні реєструйтесь та отримайте знижку!",
                   replyMarkup: MenuRegistration.LoginOrJoin);
            }
            else if (mess == "точки")
            {
                await Over.SendTextMessageAsync(message.Chat.Id, "Хуйочки :-)",
                   replyMarkup: MenuModel.MainMenu);
            }
        }

        static async Task GetCallback(CallbackQuery query, Message message)
        {
            await Over.DeleteMessageAsync(query.From.Id, query.Message.MessageId);

            await GetMenuDrinks(query, message);
            await GetAmericano(query, message);
            await GetCapuchino(query, message);
            await GetLatte(query, message);

            await GetJoinToDataBase(message, query);


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
                    replyMarkup: MenuInline.DrinksCoffee);
            }
            else if (mess == "tea")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
                    replyMarkup: MenuInline.DrinksTea);
            }
            else if (mess == "drinks")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Охоче Вам пропонуємо",
                    replyMarkup: MenuInline.DrinksDrinks);
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

        //public static async Task GetJoin(CallbackQuery query, Message message)
        //{
        //    string mess = query.Data;

        //    if(mess == "join")
        //    {
        //        await Over.SendTextMessageAsync(query.From.Id, "Консьль");

        //        Console.WriteLine("{0}", query.From.Id);
        //        Console.WriteLine("{0}", query.From.Username);
        //    }


        //}

        public static async Task GetJoinToDataBase2(Message message)
        {

            string mess2 = message.Text.ToLower();
            if (mess2 == "/start")
            {
                await Over.SendTextMessageAsync(message.From.Id, "Консoль");
                using (ContextDb contextDb = new ContextDb())
                {
                    if (contextDb.Users.FirstOrDefault(user => user.TelegramId == message.From.Id) == null)
                    {
                        BotUsers botUser = new BotUsers()
                        {
                            TelegramId = message.From.Id,
                            UserName = message.From.Username
                        };
                        await contextDb.Users.AddAsync(botUser);
                        await contextDb.SaveChangesAsync();
                        Console.WriteLine("Запить юзера в базу успешна!");
                    }

                    Console.WriteLine("Юзер Є уже");
                }

            }

        }


        public static async Task GetJoinToDataBase(Message message, CallbackQuery query)
        {
            string mess = query.Data;
            if (mess == "join")
            {
                await Over.SendTextMessageAsync(query.From.Id, "Консьль");
                using (ContextDb contextDb = new ContextDb())
                {
                    if (contextDb.Users.FirstOrDefault(user => user.TelegramId == query.From.Id) == null)
                    {
                        BotUsers botUser = new BotUsers()
                        {
                            TelegramId = (int)query.From.Id,
                            UserName = query.From.Username
                        };
                        await contextDb.Users.AddAsync(botUser);
                        await contextDb.SaveChangesAsync();
                        Console.WriteLine("Запить юзера в базу успешна!");
                    }

                    Console.WriteLine("Юзер Є уже");
                }

            }

        }





        static async Task GetLocation(Message message)
        {
            await Over.SendTextMessageAsync(message.Chat.Id, "Локація отримана, дурка виїхала",
                        replyMarkup: MenuModel.MainMenu);
        }

        static async Task BotTakeError(ITelegramBotClient botClient, Exception ex, CancellationToken token)
        {

        }






    }
}