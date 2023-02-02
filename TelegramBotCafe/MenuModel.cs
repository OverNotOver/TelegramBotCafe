using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotCafe
{
    internal static class MenuModel
    {
        public static readonly string PASSWORD_ADMIN = "qwe123";
        public static readonly string GOTO_ADMIN = "/bot_goto_admin";

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
                    new List<KeyboardButton> 
                    { 
                        new KeyboardButton("Мій профіль"), 
                        new KeyboardButton("Контакти")
                    },
                    new List<KeyboardButton>
                    {
                        new KeyboardButton($"Корзина")
                    }
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
                    new List<KeyboardButton> { new KeyboardButton("Редагування товару"), new KeyboardButton("База замовлень") },
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
