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

        public static IReplyMarkup MainMenuUser
        {
            get
            {
                List<KeyboardButton>[] buttons = new List<KeyboardButton>[]
                {
                    new List<KeyboardButton> 
                    { 
                        new KeyboardButton("Меню")                    
                    },
                    //new List<KeyboardButton> { new KeyboardButton("Авторизація"), new KeyboardButton("Точки") },
                    new List<KeyboardButton> { new KeyboardButton("Мій профіль"), new KeyboardButton("Контакти"),  new KeyboardButton("Точки") }
                };
                ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(buttons);
                return keyboardMarkup;
            }

        }


        public static IReplyMarkup MainMenuAdmin
        {
            get
            {
                List<KeyboardButton>[] buttons = new List<KeyboardButton>[]
                {
                    new List<KeyboardButton>
                    {
                        new KeyboardButton("Меню")
                    },
                    new List<KeyboardButton> { new KeyboardButton("Адмін"), new KeyboardButton("Тут!") },
                    new List<KeyboardButton> { new KeyboardButton("Мій профіль"), new KeyboardButton("Контакти"),  new KeyboardButton("Точки") }
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
                    new List<KeyboardButton> { new KeyboardButton("Щось до кави"), new KeyboardButton("Кава/Чай/Какао") },
                    new List<KeyboardButton> { new KeyboardButton("👈 Головне меню")}
                };
                ReplyKeyboardMarkup keyboardMarkup = new ReplyKeyboardMarkup(buttons);
                return keyboardMarkup;
            }

        }

      






    }
}
