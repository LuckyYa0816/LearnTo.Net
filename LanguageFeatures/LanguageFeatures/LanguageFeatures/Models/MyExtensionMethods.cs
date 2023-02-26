using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrice(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach(Product prod in productEnum)
            {
                total += prod.Price;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByCategory(
            this IEnumerable<Product> productEnum,string categoryParm)
        {
            foreach (Product prod in productEnum)
            {
                if(prod.Category == categoryParm)
                {
                    yield return prod; 
                }
            }
        }

        public static IEnumerable<Product> Filter(
            this IEnumerable<Product> productEnum,Func<Product,bool> selectorParam)
        {
            foreach (Product prod in productEnum)
            {
                if(selectorParam(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}