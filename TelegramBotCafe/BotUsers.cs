using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe
{
    public class BotUsers
    {
        public Guid Id { get; set; }    
        public long TelegramId { get; set; }    
        public string UserName { get; set; }
        public string UserPole { get; set; }
    }
}
