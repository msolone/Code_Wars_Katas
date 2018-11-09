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

    // Complete the makeAnagram function below.
    static int makeAnagram (string a, string b) {
        int combinedLength = a.Length + b.Length;
        int sharedLetters = 0;
        var dict = new Dictionary<char, int> ();

        for (var i = 0; i < b.Length; i++) {
            if (dict.ContainsKey (b[i])) {
                dict[b[i]] += 1;
            } else {
                dict.Add (b[i], 1);
            }
        }

        // Loop through determing the letters in "a" that are contained in "b"
        for (int i = 0; i < a.Length; i++) {
            // If they are in both and in there multiple times
            if (dict.ContainsKey (a[i]) && dict[a[i]] > 1) {
                // add 2 to the sharedLetters
                sharedLetters += 2;
                // Subtract one from the value
                dict[a[i]] = dict[a[i]] - 1;
                // if they are in both but only once
            } else if (dict.ContainsKey (a[i])) {
                // add 2 to the sharedLetters
                sharedLetters += 2;
                // Remove it from dictionary 
                dict.Remove (a[i]);
            }
        }
        // Subtract sharedLetters from the combined length of the strings 
        System.Console.WriteLine (combinedLength);
        System.Console.WriteLine (sharedLetters);

        return combinedLength - sharedLetters;

    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        string a = Console.ReadLine ();

        string b = Console.ReadLine ();

        int res = makeAnagram (a, b);

        textWriter.WriteLine (res);

        textWriter.Flush ();
        textWriter.Close ();
    }
}