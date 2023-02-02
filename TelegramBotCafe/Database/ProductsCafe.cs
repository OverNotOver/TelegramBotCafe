﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotCafe.Database
{
    public class ProductsCafe
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
