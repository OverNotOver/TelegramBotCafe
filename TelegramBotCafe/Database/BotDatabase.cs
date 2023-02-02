using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBotCafe.Database
{
    public static class BotDatabase
    {
        public static async Task GetJoinToDataBase(Message message)
        {
            if (message != null)
            {
                string mess2 = message.Text.ToLower();
                if (mess2 == "/start")
                {
                    await Program.Over.SendTextMessageAsync(message.From.Id, "Проверка БД");
                    using (ContextDb contextDb = new ContextDb())
                    {
                        if (contextDb.Users.FirstOrDefault(user => user.TelegramId == message.From.Id) == null)
                        {
                            BotUsers botUser = new BotUsers()
                            {
                                TelegramId = message.From.Id,
                                UserName = message.From.Username,
                                UserPole = 0
                            };
                            await contextDb.Users.AddAsync(botUser);
                            await contextDb.SaveChangesAsync();
                            await Program.Over.SendTextMessageAsync(message.From.Id, "Запить юзера в базу успешна!");
                        }
                        await Program.Over.SendTextMessageAsync(message.From.Id, "Юзер уже в базе");
                    }

                }
            }
        }

        public static async Task SelectUserPole(Message message)
        {
            await Program.Over.SendTextMessageAsync(message.From.Id, "Соединение... проверка на роль");
            using (ContextDb contextDb = new ContextDb())
            {

                var persom = contextDb.Users
                    .FirstOrDefault(per => per.TelegramId == message.From.Id);
                if (persom.UserPole == Role.Admin)
                {
                    await Program.Over.SendTextMessageAsync(message.From.Id, "Админ тут",
                        replyMarkup: MenuModel.MainMenuAdmin);
                }
                else
                {
                    await Program.Over.SendPhotoAsync
                  (chatId: message.Chat.Id,
                      photo: "https://ae01.alicdn.com/kf/Hf069064de2164e3ba3871b8f8b8dfdc14/Coffee-Shop-Sign-Premium-Coffee-Sign-Mug-Logo-Cafe-Decor-Highest-Quality-Wall-Cup-Decal-Sticker.jpg_Q90.jpg_.webp",
                      message.Text = $"Вітаю {message.From.FirstName} в нашому кафе. Можеш по пить кофе або подивитися на сиськи!",
                      replyMarkup: MenuModel.MainMenuUser);
                }

            }
        }
    }
}
