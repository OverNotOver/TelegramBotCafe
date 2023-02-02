using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotCafe.Drinks;

namespace TelegramBotCafe
{
    public static class MyProfile
    {
        public static int balance { get; set; } 
        public static IReplyMarkup MyProfileMenu
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Баланс")
                        {
                            CallbackData = "balace"
                        }
                    },
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Мої замовлення")
                        {
                            CallbackData = "myorders"
                        }
                    },
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Правила та погодження")
                        {
                            CallbackData = "rules"
                        }
                    }
                };
                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

       

        public static async Task GetMyProfile(CallbackQuery query, Message message)
        {
            string mess = query.Data;

            if (mess == "balace")
            {
                await Program.Over.SendTextMessageAsync(query.From.Id, $"💰Ваш баланс: {balance} грн",
                    replyMarkup: MenuInlineMyProfileBalance);;
            }
            else if (mess == "myorders")
            {
                await Program.Over.SendTextMessageAsync(query.From.Id, "Історія Ваших замовлень:"
                    );
            }
            else if (mess == "rules")
            {
                await Program.Over.SendTextMessageAsync(query.From.Id, "Правила:"
                   );
            }
        }




        public static IReplyMarkup MenuInlineMyProfileBalance
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton($"🤑Поповнити баланс" )
                        {
                            CallbackData = "Addbalance"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

       
    }


}
