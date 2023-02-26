﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

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
    }
}