using System;
using System.Collections.Generic;
using System.IO;

namespace PizzaSlice
{
    public class Dominos
    {
        static List<int> pizzaOrders = new List<int>();
        static int[] maxPizzaOrderNType;
        static int[] pizzaSlices;
        static List<int> selectedPizzaSlices = new List<int>();

        public static void ConvertFileToInt(string document)
        {
            string line;
            int counter = 0;
            StreamReader strRObj = new StreamReader(document);

            while ((line = strRObj.ReadLine()) != null){
                string[] file = line.Split(" ");
                counter++;

                if (counter <= 1)
                {
                    maxPizzaOrderNType = new int[file.Length];
                    for(int i = 0; i < file.Length; i++)
                    {
                        maxPizzaOrderNType[i] = Convert.ToInt32(file[i]);
                    }
                }
                else
                {
                    pizzaSlices = new int[file.Length];
                    for(int i = 0; i < file.Length; i++)
                    {
                        pizzaSlices[i] = Convert.ToInt32(file[i]);
                    }
                }
            }
        }

        public int[] OrderPizza(string document)
        {
            ConvertFileToInt(document);

            int[] sortedPizzaOrders;
            int maxPizzaOrder = maxPizzaOrderNType[0];
            int maxPizzaType = maxPizzaOrderNType[1];

            int result = pizzaSlices[maxPizzaType - 1];
            int newResult = 0;
            int stopInd = 0;
            selectedPizzaSlices.Add(result);

            // Storing pizza types starting from 0
            pizzaOrders.Add(maxPizzaType - 1);

            for(int i = maxPizzaType - 2; i >= 0; i--)
            {
                result = result + pizzaSlices[i];
                pizzaOrders.Add(i);
                int newInd = i - 1;

                if (result > maxPizzaOrder)
                {
                    result = result - pizzaSlices[i];
                    pizzaOrders.Remove(i);

                    if (newResult == 0) { 
                        newResult = result;
                        stopInd = i;
                    }
                }
                
                if(newResult != 0)
                {
                    if(newInd <= 0)
                    {
                        newInd = 0;
                        continue;
                    }
                    newResult = newResult + pizzaSlices[newInd];

                    if(newResult > result && newResult <= maxPizzaOrder)
                    {
                        result = newResult;
                        pizzaOrders.RemoveRange(stopInd, (pizzaOrders.Count - stopInd));
                        pizzaOrders.Add(newInd);
                    }
                }
            }
            sortedPizzaOrders = pizzaOrders.ToArray();

            CountingSort.CountSort(sortedPizzaOrders, sortedPizzaOrders[0] + 1);

            return sortedPizzaOrders; 
        }
    }
}
