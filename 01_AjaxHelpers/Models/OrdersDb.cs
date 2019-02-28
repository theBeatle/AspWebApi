using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace _01_AjaxHelpers.Models
{
    public class OrdersDb
    {
        public static IEnumerable<Order> Orders
        {
            get
            {
                //"Andrij","Ivan","Petro","Vasja"
                //Thread.Sleep(3000);
                List<Order> list = new List<Order>
                {
                    new Order { Id = 1, Product = "Product1", Quantity = 20, Customer = "Ivan" },
                    new Order { Id = 2, Product = "Product2", Quantity = 30, Customer = "Ivan" },
                    new Order { Id = 3, Product = "Product3", Quantity = 40, Customer = "Andrij" },
                    new Order { Id = 4, Product = "Product4", Quantity = 50, Customer = "Andrij" },
                    new Order { Id = 5, Product = "Product5", Quantity = 60, Customer = "Petro" },
                    new Order { Id = 6, Product = "Product6", Quantity = 80, Customer = "Petro" },
                    new Order { Id = 7, Product = "Product7", Quantity = 100, Customer = "Vasja" },
                    new Order { Id = 8, Product = "Product8", Quantity = 300, Customer = "Vasja" },
                };
                return list;
            }
        }
    }
}