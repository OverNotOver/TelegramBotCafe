using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotCafe
{
    public static class ProductsInlineInfo
    {

        public static IReplyMarkup LatteInfo
        {

            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("350лм - 40грн")
                        {
                            CallbackData = "latte350"
                        },
                        new InlineKeyboardButton("500лм - 60грн")
                        {
                            CallbackData = "latte500"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }
        public static IReplyMarkup LatteInfoBuy
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("1")
                        {
                            CallbackData = "lattebuy1"
                        },
                        new InlineKeyboardButton("2")
                        {
                            CallbackData = "lattebuy2"
                        },
                         new InlineKeyboardButton("3")
                        {
                            CallbackData = "lattebuy3"
                        }
                    },
                     new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Більше? Введіть кількість!")
                        {
                            CallbackData = "lattebuyQt"
                        },

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
                            CallbackData = "capuchi300"
                        },
                        new InlineKeyboardButton("450лм - 50грн")
                        {
                            CallbackData = "capuchi450"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }
        public static IReplyMarkup CapuchinoInfoBuy
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("1")
                        {
                            CallbackData = "capuchibuy1"
                        },
                        new InlineKeyboardButton("2")
                        {
                            CallbackData = "capuchibuy2"
                        },
                         new InlineKeyboardButton("3")
                        {
                            CallbackData = "capuchibuy3"
                        }
                    },
                     new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Більше? Введіть кількість!")
                        {
                            CallbackData = "capuchibuyQt"
                        },

                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

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
                            CallbackData = "americano150"
                        },
                        new InlineKeyboardButton("220лм - 25грн")
                        {
                            CallbackData = "americano220"
                        }
                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

        public static IReplyMarkup AmericanoInfoBuy
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("1")
                        {
                            CallbackData = "americanobuy1"
                        },
                        new InlineKeyboardButton("2")
                        {
                            CallbackData = "americanobuy2"
                        },
                         new InlineKeyboardButton("3")
                        {
                            CallbackData = "americanobuy3"
                        }
                    },
                     new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Більше? Введіть кількість!")
                        {
                            CallbackData = "americanobuyQt"
                        },

                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }


















    }
}
