using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaSlice;

namespace Pizza_Slice_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMaximumPizzaOrder1()
        {
            string document = @"./Inputs/a_example.in";

            PizzaSlice pizzaObj = new PizzaSlice();

            string[] pizzaMaxNTypes = pizzaObj.MaxNType(document);

            Assert.AreEqual(pizzaMaxNTypes[0], "17");
        }

        [TestMethod]
        public void TestMaximumPizzaOrder2()
        {
            string document = @"./Inputs/b_small.in";

            PizzaSlice pizzaObj = new PizzaSlice();

            string[] pizzaMaxNTypes = pizzaObj.MaxNType(document);

            Assert.AreEqual(pizzaMaxNTypes[0], "100");
        }

        [TestMethod]
        public void TestMaximumPizzaOrder3()
        {
            string document = @"./Inputs/c_medium.in";

            PizzaSlice pizzaObj = new PizzaSlice();

            string[] pizzaMaxNTypes = pizzaObj.MaxNType(document);

            Assert.AreEqual(pizzaMaxNTypes[0], "4500");
        }
        [TestMethod]
        public void TestMaximumPizzaOrder4()
        {
            string document = @"./Inputs/d_quite_big.in";

            PizzaSlice pizzaObj = new PizzaSlice();

            string[] pizzaMaxNTypes = pizzaObj.MaxNType(document);

            Assert.AreEqual(pizzaMaxNTypes[0], "1000000000");
        }

        [TestMethod]
        public void TestMaximumPizzaOrder5()
        {
            string document = @"./Inputs/e_also_big.in";

            PizzaSlice pizzaObj = new PizzaSlice();

            string[] pizzaMaxNTypes = pizzaObj.MaxNType(document);

            Assert.AreEqual(pizzaMaxNTypes[0], "505000000");
        }
    }
}
