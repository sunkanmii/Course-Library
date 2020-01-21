using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaSlice;

namespace Pizza_Slice_Unit_Test
{
    [TestClass]
    public class TestOrderPizzas
    {
        [TestMethod]
        public void TestPizzaOrder1()
        {
            string document = @"./Inputs/a_example.in";

            Dominos pizzaObj = new Dominos();

            int[] pizzaOrders = pizzaObj.OrderPizza(document);

            Assert.AreEqual(pizzaOrders[0], 0);
        }
    }
}
