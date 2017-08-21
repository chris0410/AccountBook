using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class MoneyViewModel
    {
        public string category { get; set; }
        public DateTime date { get; set; }
        public int money { get; set; }
        public string memo { get; set; }

    }
}