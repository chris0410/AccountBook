using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        public ActionResult Money()
        {
            var result = new Combine() { Money = null, Moneys = Repository.VMPrository };
            return View(result);
        }

        [HttpPost]
        public ActionResult Money([Bind(Prefix = "Money")]MoneyViewModel PageData)
        {

            if (!string.IsNullOrWhiteSpace(PageData.category) && !string.IsNullOrWhiteSpace(PageData.date))
            {
                Repository.VMPrository.Add(PageData);
            }

            var result = new Combine() { Money = PageData, Moneys = Repository.VMPrository };

            return View(result);
        }
    }
}