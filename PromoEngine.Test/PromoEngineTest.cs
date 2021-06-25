using NUnit.Framework;
using PromoEngine.PromoEngine.Interfaces;
using PromoEngine.PromoEngine.BL;
using PromoEngine.PromoEngine.Models;
using System.Collections.Generic;

namespace PromoEngine.Test
{
    public class PromoEngineTest
    {
        private IPromoEngineLogic promoObj;
        [SetUp]
        public void Setup()
        {
            promoObj = new PromoEngineLogic();
        }

        [Test]
        [TestCase("ScenarioA", 100)]
        [TestCase("ScenarioB", 370)]
        [TestCase("ScenarioC", 280)]
        public void Add_GetTotalPrice_Scenarios_Returns(string _scenario, int expected)
        {
            double result = promoObj.GetTotalPrice(GetProducts(_scenario));
            Assert.AreEqual(expected, result);
        }
        private List<Product> GetProducts(string _scenario)
        {
            List<Product> products = new List<Product>();
            if (_scenario == "ScenarioA")
            {
                products.Add(new Product("A"));
                products.Add(new Product("B"));
                products.Add(new Product("C"));
            }
            if (_scenario == "ScenarioB")
            {
                products.Add(new Product("A"));
                products.Add(new Product("A"));
                products.Add(new Product("A"));
                products.Add(new Product("A"));
                products.Add(new Product("A"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("C"));
            }
            if (_scenario == "ScenarioC")
            {
                products.Add(new Product("A"));
                products.Add(new Product("A"));
                products.Add(new Product("A"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("B"));
                products.Add(new Product("C"));
                products.Add(new Product("D"));
            }
            return products;
        }
    }
}
