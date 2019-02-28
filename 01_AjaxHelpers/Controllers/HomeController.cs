using _01_AjaxHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_AjaxHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string id)
        {
            return View("Index", (object)id);
        }

        public ActionResult OrdersData(string id)
        {
            var products = OrdersDb.Orders;
            if (!String.IsNullOrEmpty(id) && id != "All")
            {
                products = products.Where(cust => cust.Customer == id);
            }
            return PartialView(products);
        }
    }
}