using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotCafe
{
    public static class MenuRegistration
    {
        public static IReplyMarkup LoginOrJoin
        {
            get
            {

                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Вхід")
                        {
                            CallbackData = "login"
                        },
                        new InlineKeyboardButton("Реєстрація")
                        {
                            CallbackData = "join"
                        }

                    }
                };
                InlineKeyboardMarkup keyboardMarkup = new InlineKeyboardMarkup(buttons);
                return keyboardMarkup;
            }

        }




    }

}
