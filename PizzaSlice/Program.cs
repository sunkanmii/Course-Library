using System;

namespace PizzaSlice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dominos domObj1 = new Dominos();

            string document1 = @"./Inputs/a_example.in";
            int[] sortedPizzaOrders1 = domObj1.OrderPizza(document1);

            Console.WriteLine(sortedPizzaOrders1.Length);
            foreach(int element in sortedPizzaOrders1) { 
                Console.Write(element + " ");
            }

             //One at a time
//            Dominos domObj2 = new Dominos();
//
//            string document2 = @"./Inputs/b_small.in";
//
//            int[] sortedPizzaOrders2 = domObj2.OrderPizza(document2);
//
//
//            Console.WriteLine(sortedPizzaOrders2.Length);
//            foreach (int element in sortedPizzaOrders2)
//            {
//                Console.Write(element + " ");
//            }
//
//            Dominos domObj3 = new Dominos();
//
//            string document3 = @"./Inputs/c_medium.in";
//            int[] sortedPizzaOrders3 = domObj3.OrderPizza(document3);
//
//
//            Console.WriteLine(sortedPizzaOrders3.Length);
//            foreach (int element in sortedPizzaOrders3)
//            {
//                Console.Write(element + " ");
//            }
//
//            Dominos domObj4 = new Dominos();
//
//            string document4 = @"./Inputs/d_quite_big.in";
//            int[] sortedPizzaOrders4 = domObj4.OrderPizza(document4);
//
//
//            Console.WriteLine(sortedPizzaOrders4.Length);
//            foreach (int element in sortedPizzaOrders4)
//            {
//                Console.Write(element + " ");
//            }
//
//            Dominos domObj5 = new Dominos();
//
//            string document5 = @"./Inputs/e_also_big.in";
//            int[] sortedPizzaOrders5 = domObj5.OrderPizza(document5);
//
//
//            Console.WriteLine(sortedPizzaOrders5.Length);
//            foreach (int element in sortedPizzaOrders5)
//            {
//                Console.Write(element + " ");
//            }
        }
    }
}
