using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the maximumToys function below.
    // Works Not Fast Enough!!!!
    static int maximumToys(int[] prices, int k) {
        var filteredPrices = prices.Where(i => i <= k).ToArray();
        // System.Console.WriteLine("Unsorted");
        // foreach (var item in filteredPrices)
        //     {
        //         System.Console.WriteLine(item);
        //     }

        var removeEndPoint = filteredPrices.Length - 1;
        for (int i = 0; i < filteredPrices.Length; i++)
            {
            for (int j = 0; j < removeEndPoint; j++)
                {
                    if (filteredPrices[j] > filteredPrices[j + 1]) 
                    {
                        var placeholder = filteredPrices[j];
                        filteredPrices[j] = filteredPrices[j + 1];
                        filteredPrices[j + 1] = placeholder;
                    }
                } 
            removeEndPoint--;
            }
            // System.Console.WriteLine("Sorted");
            // foreach (var item in filteredPrices)
            // {
            //     System.Console.WriteLine(item);
            // }

            var toys = 0;
            var totalPrice = 0;
            var index = 0;
            for (var i = 0; i < filteredPrices.Length; i++)
            {
                if (totalPrice + filteredPrices[i] <= k)
                {
                    totalPrice += filteredPrices[i];
                    toys++;
                }
            }
            // while (totalPrice + filteredPrices[index] < k && index <= filteredPrices.Length) 
            // {
            //     totalPrice += filteredPrices[index];
            //     toys++;
            //     index++;
            // }
            return toys;
        }


        // Step 1: Filter all results greater than k
        // Step 2: Sort remaining prices
        // Step 3: Loop through list Adding values until number is greater than k
        // *** Must be able to stop 1 shy of going over




    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}