using System.Collections.Generic;
using NUnit.Framework;
using PhaseProject4.Models;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            PizzaBO context = new PizzaBO();
            int expectedValue = 8;
            List<Pizza> pizzas = context.GetItems();
            int actualValue = 0;
            foreach (var p in pizzas)
                actualValue++;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void Test2()
        {
            PizzaBO context = new PizzaBO();
            string expectedValue = "Farmhouse";
            var pizza = context.GetItemById(2);
            var actualValue = pizza.pname;
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void Test3()
        {
            PizzaBO context = new PizzaBO();
            string expectedValue = "Margherita";
            string actualValue = context.GetItemByName(3);
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}