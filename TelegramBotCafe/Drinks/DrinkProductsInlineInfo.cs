using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotCafe.Database;

namespace TelegramBotCafe.Drinks
{
    public static class DrinkProductsInlineInfo
    {

        public static IReplyMarkup AmericanoInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("150лм - 20грн")
                        {
                            CallbackData = "Американо(150)"
                        },
                        new InlineKeyboardButton("220лм - 25грн")
                        {
                            CallbackData = "Американо(220)"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

        public static IReplyMarkup LatteInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton($"300лм - 40грн")
                        {
                            CallbackData = "Латте(300)"
                        },
                        new InlineKeyboardButton("500лм - 60грн")
                        {
                            CallbackData = "Латте(500)"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

        public static IReplyMarkup CapuchinoInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("300лм - 35грн")
                        {
                            CallbackData = "Капучино(300)"
                        },
                        new InlineKeyboardButton("450лм - 50грн")
                        {
                            CallbackData = "Капучино(450)"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

        public static IReplyMarkup KakaoInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("400лм - 40грн")
                        {
                            CallbackData = "Какао(400)"
                        },
                        new InlineKeyboardButton("500лм - 55грн")
                        {
                            CallbackData = "Какао(500)"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }






        public static IReplyMarkup TeaGreenInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("300лм - 25грн")
                        {
                            CallbackData = "Зелений_чай(300)"
                        },
                        new InlineKeyboardButton("500лм - 30грн")
                        {
                            CallbackData = "Зелений_чай(500)"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }
        public static IReplyMarkup TeaBlackInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("300лм - 25грн")
                        {
                            CallbackData = "Чорний_чай(300)"
                        },
                        new InlineKeyboardButton("500лм - 30грн")
                        {
                            CallbackData = "Чорний_чай(500)"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }
        public static IReplyMarkup TeaFruitInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("300лм - 25грн")
                        {
                            CallbackData = "Фруктовий_чай(300)"
                        },
                        new InlineKeyboardButton("500лм - 30грн")
                        {
                            CallbackData = "Фруктовий_чай(500)"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }









        public static IReplyMarkup BackOrPay
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Продовжити вибір")
                        {
                            CallbackData = "back_to_main"
                        },
                        new InlineKeyboardButton("Оформити замовлення")
                        {
                            CallbackData = "payment"
                        },
                    },
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

    }
}
