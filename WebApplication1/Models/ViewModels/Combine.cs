using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class Combine
    {
        public MoneyViewModel Money { get; set; }
        public List<MoneyViewModel> Moneys { get; set; }
    }
}