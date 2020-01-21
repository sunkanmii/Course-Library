using System;

namespace PizzaSlice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dominos domObj = new Dominos();

            string document = @"./Inputs/d_quite_big.in";
            int[] sortedPizzaOrders = domObj.OrderPizza(document);

            foreach(int element in sortedPizzaOrders) { 
                Console.WriteLine(element);
            }
        }
    }
}
