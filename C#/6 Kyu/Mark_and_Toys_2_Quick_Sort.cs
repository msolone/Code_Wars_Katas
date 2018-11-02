using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

class Solution {

    // Complete the maximumToys function below.
    // Initiate Quick Sort by calling it recursively
    public static void quicksort (int[] array) {
        quicksort (array, 0, array.Length - 1);
    }
    // Determine pivot, and quick sort each partition seperately
    public static void quicksort (int[] array, int left, int right) {
        // If the left passes right we stop
        if (left >= right) {
            return;
        }
        // setting pivot to middle
        int pivot = array[left + (right - left) / 2];
        // calling partition to return the index of the new pivot
        int index = partition (array, left, right, pivot);
        // Quick Sort Left Side
        quicksort (array, left, index - 1);
        // Quick Sort Right Side
        quicksort (array, index, right);
    }

        public static int partition (int[] array, int left, int right, int pivot) {
        // Before partition is sorted
        while (left <= right) {
            // if the value at this index is less then pivot, move on, it doesnt need to be swapped
            while (array[left] < pivot) {
                left++;
            }
            // if the value at this index is greater then pivot, move, it doesnt need to be swapped
            while (array[right] > pivot) {
                right--;
            }
            // Swapping places with placeholder
            if (left <= right) {
                var placeholder = left;
                left = right;
                right = placeholder;
                left++;
                right--;
            }
        }
        return left;
    }

    static int maximumToys (int[] prices, int k) {
        var filteredPrices = prices.Where (i => i <= k).ToArray ();
        System.Console.WriteLine ("Unsorted");
        foreach (var item in filteredPrices) {
            System.Console.WriteLine (item);
        }

        quicksort (filteredPrices, 0, filteredPrices.Length -1);

        System.Console.WriteLine ("Sorted");
        foreach (var item in filteredPrices) {
            System.Console.WriteLine (item);
        }

        var toys = 0;
        var totalPrice = 0;
        var index = 0;
        for (var i = 0; i < filteredPrices.Length; i++) {
            if (totalPrice + filteredPrices[i] <= k) {
                totalPrice += filteredPrices[i];
                toys++;
            }
        }
        return toys;
    }

    // Step 1: Filter all results greater than k
    // Step 2: Sort remaining prices
    // Step 3: Loop through list Adding values until number is greater than k
    // *** Must be able to stop 1 shy of going over

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine ().Split (' ');

        int n = Convert.ToInt32 (nk[0]);

        int k = Convert.ToInt32 (nk[1]);

        int[] prices = Array.ConvertAll (Console.ReadLine ().Split (' '), pricesTemp => Convert.ToInt32 (pricesTemp));
        int result = maximumToys (prices, k);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}