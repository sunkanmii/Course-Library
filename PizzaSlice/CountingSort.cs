using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaSlice
{
    public class CountingSort
    {
        public void CountSort(int[] arr)
        {
            int arrLength = arr.Length;

            int[] output = new int[arrLength];

            int[] count = new int[505000];

            for (int i = 0; i < 505000; i++)
            {
                count[i] = 0;
            }

            // store count of each character 
            for (int i = 0; i < arrLength; i++)
            {
                //Implicit type conversion from char to int
                //Possible in both C# and Java.
                ++count[arr[i]];
            }

            // Change count[i] so that count[i]  
            // now contains actual position of  
            // the character in output array 
            for (int i = 1; i < 505000; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = arrLength - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                --count[arr[i]];
            }

            // Copy the output array to arr, so 
            // that arr now contains sorted  
            // characters 
            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}
