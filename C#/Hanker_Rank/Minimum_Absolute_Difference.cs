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

    // Complete the minimumAbsoluteDifference function below.
    
    static int minimumAbsoluteDifference (int[] arr) {
//       // Works but is O(n^2) need to optimize
        
        // var lowest = Math.Abs (arr[0] - arr[1]);
        // System.Console.WriteLine (lowest);

        // for (var i = 0; i < arr.Length; i++) {
        //     for (var j = 1; j < arr.Length; j++) {
        //         if (Math.Abs (arr[i] - arr[j]) < lowest && i != j) {
        //             lowest = Math.Abs (arr[i] - arr[j]);
        //         }
        //     }
        // }
        // System.Console.WriteLine (lowest);
        // return lowest;
        
        // Optimized Answer O(n * log(n))

        Array.Sort(arr);
    
        var lowest = Math.Abs (arr[0] - arr[1]);
        for (var i = 1; i < arr.Length - 1; i++) {
            // Only need consecutive pairs because those will yield the lowest abs diff
            if (Math.Abs(arr[i] - arr[i + 1]) < lowest) {
                lowest = Math.Abs(arr[i] - arr[i + 1]);
            }
        }

        return lowest;

    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        int n = Convert.ToInt32 (Console.ReadLine ());

        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (' '), arrTemp => Convert.ToInt32 (arrTemp));
        int result = minimumAbsoluteDifference (arr);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}