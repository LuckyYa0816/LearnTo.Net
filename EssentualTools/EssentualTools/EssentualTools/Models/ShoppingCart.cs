using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentualTools.Models
{
    public class ShoppingCart
    {
        //private LinqValueCalculator calc;
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator calcParam)
        {
            //this.calc = calcParam;
            calc= calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalcuateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}