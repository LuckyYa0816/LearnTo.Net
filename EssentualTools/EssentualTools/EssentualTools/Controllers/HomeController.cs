using EssentualTools.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EssentualTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;

        public HomeController(IValueCalculator calcParam,IValueCalculator calc2)
        {
            calc= calcParam;
        }

        private Product[] products = {
            new Product{Name = "Kayak",Category="Watersports",Price=275M},
            new Product{Name = "Lifejacket",Category="Watersports",Price=48.95M},
            new Product{Name = "Soccer ball",Category="Soccer",Price=19.50M},
            new Product{Name = "Corner flag",Category="Soccer",Price=34.95M}
        };

        // GET: Home
        public ActionResult Index()
        {
            /*
            IValueCalculator calc = new LinqValueCalculator();
            ShoppingCart cart = new ShoppingCart(calc) { Products= products };
            decimal totalValue = cart.CalcuateProductTotal();
            return View(totalValue);*/
            /*
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
            IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalcuateProductTotal();
            return View(totalValue);*/

            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalcuateProductTotal();
            return View(totalValue);
        }
    }
}