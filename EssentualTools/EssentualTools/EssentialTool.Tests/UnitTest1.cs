using EssentualTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

namespace EssentialTool.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IDiscountHelper getTestObject()
        {
            return new MiniumDiscountHelper();
        }

        [TestMethod]
        public void Discount_Above_100()
        {
            //准备
            IDiscountHelper target = getTestObject();
            decimal total = 200;

            //动作
            var discountedTotal = target.ApplyDiscount(total);

            //断言
            Assert.AreEqual(total * 0.9M, discountedTotal);
        }

        [TestMethod]
        public void Discount_Between_10_And_100()
        {
            //准备
            IDiscountHelper target = getTestObject();

            //动作
            decimal TenDollarDiscount = target.ApplyDiscount(10);
            decimal HundredDollarDiscount = target.ApplyDiscount(100);
            decimal FiftyDollarDiscount = target.ApplyDiscount(50);

            //断言
            Assert.AreEqual(5, TenDollarDiscount);
            Assert.AreEqual(95, HundredDollarDiscount);
            Assert.AreEqual(45, FiftyDollarDiscount);
        }

        [TestMethod]
        public void Discount_Less_Than_10()
        {
            //准备
            IDiscountHelper target = getTestObject();

            //动作
            decimal dicount5 = target.ApplyDiscount(5);
            decimal discount0 = target.ApplyDiscount(0);

            //断言
            Assert.AreEqual(5, dicount5);
            Assert.AreEqual(0, discount0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Discount_Negative_Total()
        {
            //准备
            IDiscountHelper target = getTestObject();

            target.ApplyDiscount(-1);
        }
    }
}
