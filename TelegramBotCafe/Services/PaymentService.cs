using LiqPay.SDK;
using LiqPay.SDK.Dto.Enums;
using LiqPay.SDK.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TelegramBotCafe.Database;

namespace TelegramBotCafe.Services
{
    public static class PaymentService
    {
        public static async Task<string> CreatePay(long userId)
        {
            LiqPayRequest request = new LiqPayRequest()
            {
                ResultUrl = "https://localhost:44375/OrderPay/CheckPay",
                ServerUrl = "https://localhost:44375/OrderPay/CheckPay",
                Amount = 0,
                Currency = "UAH",
                OrderId = Guid.NewGuid().ToString(),
                ActionPayment = LiqPayRequestActionPayment.Pay,
                Action = LiqPayRequestAction.InvoiceSend,
                Email = "bisnesbrend@gmail.com",
                Goods = new List<LiqPayRequestGoods>()
            };

            using (ContextDb database = new ContextDb())
            {
                var user = await database.Users.FirstAsync(x => x.TelegramId == userId);

                var order = database.Orders
                    .Include(ord => ord.Products)
                        .ThenInclude(prod => prod.Product)
                    .FirstOrDefault(order => order.UserOrder.Id == user.Id && order.Active == true);

                request.Amount = order.Products.Sum(prod => prod.Product.Price);

                foreach (var prod in order.Products)
                {
                    request.Goods.Add(new LiqPayRequestGoods()
                    {
                        Name = prod.Product.Name,
                        Amount = prod.Product.Price,
                        Count = 1,
                        Unit = "од"
                    });
                }

                order.Active = false;
                database.SaveChanges();

                LiqPayModel liqPay = new LiqPayModel();
                return await liqPay.Pay(request);
            }
        }
    }

    class LiqPayModel
    {
        const string _primary = "sandbox_i35400958790";
        const string _foreign = "sandbox_SvpXo5ND3ZQLqzSvsTfjZ9mTXEnxbh48eX1VeiVb";
        readonly LiqPayClient _client;

        public LiqPayModel()
        {
            _client = new LiqPayClient(_primary, _foreign);
            _client.IsCnbSandbox = true;
        }

        public async Task<string> Pay(LiqPayRequest request)
        {
            var response = await _client.RequestAsync("request", request);
            return response.Href;
        }

    }
}
