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
        public Role UserPole { get; set; }
    }

    public enum Role
    {
        User,
        Admin
    }

}
