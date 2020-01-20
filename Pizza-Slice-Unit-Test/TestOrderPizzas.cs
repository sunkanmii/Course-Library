using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pizza_Slice_Unit_Test
{
    [TestClass]
    public class TestOrderPizzas
    {
        [TestMethod]
        public void TestPizzaOrder1()
        {
            string document = @"./Inputs/a_example.in";

            string[] pizzaMaxNTypes = pizzaObj.MaxNType(document);

            int[] pizzaOrders = pizzaObj.OrderPizza(document);

            Assert.AreEqual(pizzaOrders[2], "8");
        }
    }
}
