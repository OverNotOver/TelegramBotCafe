using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBotCafe.Drinks;

namespace TelegramBotCafe.Foods
{
    public static class MenuInlineFoods
    {
        public static IReplyMarkup FoodsForCoffee
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("Круассан")
                        {
                            CallbackData = "cruasan"
                        },
                        new InlineKeyboardButton("Макарон")
                        {
                            CallbackData = "makaron"
                        },
                        new InlineKeyboardButton("Еклер")
                        {
                            CallbackData = "ecler"
                        }
                    }
                };
                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }
        }

        public static IReplyMarkup Cruassans
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("З шоколадом")
                        {
                            CallbackData = "Круассан(Шоколад)"

                        },
                        new InlineKeyboardButton("З малиною")
                        {
                            CallbackData = "Круассан(Малина)"
                        },
                        new InlineKeyboardButton("З фісашкою")
                        {
                            CallbackData = "Круассан(Фісташка)"
                        }
                    }

              };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }

        public static IReplyMarkup Macarons
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("З лохиною")
                        {
                            CallbackData = "Макарон(Лохина)"

                        },
                        new InlineKeyboardButton("З полуницею")
                        {
                            CallbackData = "Макарон(Полуниця)"
                        },
                        new InlineKeyboardButton("З черешнею")
                        {
                            CallbackData = "Макарон(Черешня)"
                        }
                    }

              };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }

        public static IReplyMarkup Eclers
        {
            get
            {
                List<InlineKeyboardButton>[] buttons = new List<InlineKeyboardButton>[]
                {
                    new List<InlineKeyboardButton>
                    {
                        new InlineKeyboardButton("З ананасом")
                        {
                            CallbackData = "Еклер(Ананас)"

                        },
                        new InlineKeyboardButton("З полуницею")
                        {
                            CallbackData = "Еклер(Полуниця)"
                        },
                        new InlineKeyboardButton("З бананом")
                        {
                            CallbackData = "Еклер(Банан)"
                        }
                    }

              };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }

       



    }
}
