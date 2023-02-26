using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        /*
        private String name;
        private String description;
        private decimal price;
        private string category;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
    
        */
        
        //使用 Automatic Property 自动属性
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}