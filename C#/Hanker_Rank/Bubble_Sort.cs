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

    // Complete the countSwaps function below.
    static void countSwaps (int[] a) {
        int swaps = 0;
        // Each pass will place the largest value at the end
        // so by setting the limiter to this, it will reduce 
        // the amount of items in the array to loop though by
        // 1 for every pass
        int removeLastIndex = a.Length - 1;
        for (int i = 0; i < a.Length; i++) {
            for (int j = 0; j < removeLastIndex; j++) {
                if (a[j] > a[j + 1]) {
                    var placeholder = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = placeholder;
                    swaps++;
                }
            }
            removeLastIndex--;
        }
        System.Console.WriteLine ($"Array is sorted in {swaps} swaps.");
        System.Console.WriteLine ($"First Element: {a[0]}");
        System.Console.WriteLine ($"Last Element: {a[a.Length - 1]}");
    }

    static void Main (string[] args) {
        int n = Convert.ToInt32 (Console.ReadLine ());

        int[] a = Array.ConvertAll (Console.ReadLine ().Split (' '), aTemp => Convert.ToInt32 (aTemp));
        countSwaps (a);
    }
}
