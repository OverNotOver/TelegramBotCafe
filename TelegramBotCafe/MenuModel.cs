using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotCafe
{
    internal static class MenuModel
    {

        public static IReplyMarkup MainMenu
        {
            get
            {
                List<KeyboardButton>[] buttons = new List<KeyboardButton>[]
                {
                    new List<KeyboardButton> { new KeyboardButton("Меню") },
                    new List<KeyboardButton> { new KeyboardButton("Акции"), new KeyboardButton("Точки") },
                    new List<KeyboardButton> { new KeyboardButton("Доставка"), new KeyboardButton("Контакти") }
                };
                ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(buttons);
                return keyboardMarkup;
            }

        }

        public static IReplyMarkup ProductMenu
        {
            get
            {
                List<KeyboardButton>[] buttons = new List<KeyboardButton>[]
                {
                    //new List<KeyboardButton> 
                    //{ 
                    //    new KeyboardButton("Щось смачне до кави"), 
                    //    new KeyboardButton("Гарячее") 
                    //},
                    new List<KeyboardButton> { new KeyboardButton("Кальян"), new KeyboardButton("Напої") },
                    new List<KeyboardButton> { new KeyboardButton("👈 Головне меню")}
                };
                ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(buttons);
                return keyboardMarkup;
            }

        }

        public static IReplyMarkup ProductMenuBack
        {
            get
            {
                List<KeyboardButton>[] buttons = new List<KeyboardButton>[]
                {
                    //new List<KeyboardButton> 
                    //{ 
                    //    new KeyboardButton("Щось смачне до кави"), 
                    //    new KeyboardButton("Гарячее") 
                    //},
                    //new List<KeyboardButton> { new KeyboardButton("Кальян"), new KeyboardButton("Напої") },
                    new List<KeyboardButton> { new KeyboardButton("👈 Головне меню")}
                };
                ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(buttons);
                return keyboardMarkup;
            }

        }























    }
}
