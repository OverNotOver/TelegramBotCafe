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
                        new InlineKeyboardButton("Зі шоколадом")
                        {
                            CallbackData = "сruassanschoko"

                        },
                        new InlineKeyboardButton("Зі малиною")
                        {
                            CallbackData = "сruassanschokomalina"
                        },
                        new InlineKeyboardButton("Зі фісашкою")
                        {
                            CallbackData = "сruassanschokofistashka"
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
                        new InlineKeyboardButton("з лохиною")
                        {
                            CallbackData = "macaronloh"

                        },
                        new InlineKeyboardButton("З малиною")
                        {
                            CallbackData = "macaronmalina"
                        },
                        new InlineKeyboardButton("З фісашкою")
                        {
                            CallbackData = "macaronfistashka"
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
                            CallbackData = "eklerananac"

                        },
                        new InlineKeyboardButton("З полуницею")
                        {
                            CallbackData = "eklerpolynica"
                        },
                        new InlineKeyboardButton("З бананом")
                        {
                            CallbackData = "eklerbanan"
                        }
                    }

              };

                InlineKeyboardMarkup markup = new InlineKeyboardMarkup(buttons);
                return markup;
            }

        }

        public static async Task PayCruassan(CallbackQuery query, Message message)
        {

            //await Over.DeleteMessageAsync(query.From.Id, query.Message.MessageId);
            string mess = query.Data;

            if (mess == "сruassanschoko")
            {
               
            }
            //else if (mess == "сruassanschokomalina")
            //{
            //    await Program.Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: DrinkProductsInlineInfo.AmericanoInfoBuy);
            //    Program.BasketPayOrder = 100;

            //}
            //else if (mess == "сruassanschokofistashka")
            //{
            //    await Program.Over.SendTextMessageAsync(query.From.Id, "Введіть кількість", replyMarkup: DrinkProductsInlineInfo.AmericanoInfoBuy);
            //}

        }
    }
}
