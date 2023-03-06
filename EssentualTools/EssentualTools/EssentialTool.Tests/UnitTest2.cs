using EssentualTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;

namespace EssentialTool.Tests
{
    [TestClass]
    public class UnitTest2
    {
        private Product[] products = {
            new Product{Name = "Kayak",Category="Watersports",Price=275M},
            new Product{Name = "Lifejacket",Category="Watersports",Price=48.95M},
            new Product{Name = "Soccer ball",Category="Soccer",Price=19.50M},
            new Product{Name = "Corner flag",Category="Soccer",Price=34.95M}
        };

        [TestMethod]
        public void Sum_Products_Correctly()
        {
            /*
            //准备
            var discounter = new MiniumDiscountHelper();
            var target = new LinqValueCalculator(discounter);
            var goalTotal = products.Sum(e => e.Price);
            */

            //准备
            Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();
            mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);
            var target = new LinqValueCalculator(mock.Object);

            //动作
            var result = target.ValueProducts(products);

            //断言
            Assert.AreEqual(products.Sum(e=>e.Price),result);
        }
    }
}
