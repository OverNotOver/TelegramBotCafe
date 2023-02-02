using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotCafe.Drinks
{
    public static class MenuInlineDrinks
    {
        public static IReplyMarkup Drinks
        {
            get
            {

                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Кава/Какао")
                        {
                            CallbackData = "coffee"
                        },
                        new InlineKeyboardButton("Чай")
                        {
                            CallbackData = "tea"
                        }
                        //,
                        // new InlineKeyboardButton("Алкоголь - НІ")
                        //{
                        //    CallbackData = "drinks"
                        //},
                    }
                    //,
                    //new List<InlineKeyboardButton>
                    //{
                    //    new InlineKeyboardButton("Пиво")
                    //    {
                    //        CallbackData = "bear"
                    //    },
                    //    new InlineKeyboardButton("Коктелі")
                    //    {
                    //        CallbackData = "koktels"
                    //    },
                    //      new InlineKeyboardButton("Щось міцніше")
                    //    {
                    //        CallbackData = "others"
                    //    },
                    //}
                };
                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }
        public static IReplyMarkup DrinksBear
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {

                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Темне")
                        {
                            CallbackData = "bear_black"
                        },
                        new InlineKeyboardButton("Світле")
                        {
                            CallbackData = "bear_white"
                        },

                    },
                     new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Bud")
                        {
                            CallbackData = "bear_bud"
                        },
                        new InlineKeyboardButton("Львівське 1715")
                        {
                            CallbackData = "bear_1715"
                        },

                    }
                };
                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }
        public static IReplyMarkup DrinksCoffee
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Латте")
                        {
                            CallbackData = "latte"

                        },
                        new InlineKeyboardButton("Капучино")
                        {
                            CallbackData = "capuchino"
                        },
                        new InlineKeyboardButton("Американо")
                        {
                            CallbackData = "americano"
                        }
                    }
                    //,
                    //new List<InlineKeyboardButton>
                    //{
                    //    new InlineKeyboardButton("Еспрессо")
                    //    {
                    //        CallbackData = "latte"
                    //    },
                    //    new InlineKeyboardButton("Какао")
                    //    {
                    //        CallbackData = "kakao"
                    //    }
                    //    //,
                    //    //new InlineKeyboardButton("Айс Латте")
                    //    //{
                    //    //    CallbackData = "icelatte"
                    //    //}
                    //}

              };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }
        public static IReplyMarkup DrinksTea
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Зелений чай")
                        {
                            CallbackData = "green_tea"
                        },
                        new InlineKeyboardButton("Чорний чай")
                        {
                            CallbackData = "black_tea"
                        },
                        new InlineKeyboardButton("Фруктовий чай")
                        {
                            CallbackData = "fruit_tea"
                        }
                    }
              };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }
        public static IReplyMarkup DrinksDrinks
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Мінеральна вода")
                        {
                            CallbackData = "mineralwater"
                        },
                        new InlineKeyboardButton("7Up")
                        {
                            CallbackData = "7up"
                        },
                        new InlineKeyboardButton("Pepsi")
                        {
                            CallbackData = "pepsi"
                        }
                    }
              };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }
        public static IReplyMarkup DrinksKoktels
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Байрактар")
                        {
                            CallbackData = "ddd"

                        },

                    },
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Джавелін")
                        {
                            CallbackData = "ddd"
                        },

                    },
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Мохіто")
                        {
                            CallbackData = "ddd"
                        },

                    },
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Секс на пляжі")
                        {
                            CallbackData = "ddd"
                        },

                    },
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("О кровавлена Мері")
                        {
                            CallbackData = "ddd"
                        },

                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }
        public static IReplyMarkup DrinksOther
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Пока немає, назад?")
                        {
                            CallbackData = "ddd"
                        },

                    }
                };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }






    }



}
