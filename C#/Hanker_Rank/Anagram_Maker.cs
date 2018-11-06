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
            // If they are in both, add 2 to the sharedLetters
            if (dict.ContainsKey (a[i])) {
                sharedLetters += 2;
                dict.Remove (key: a[i]);
            }
        }
        // Subtract sharedLetters from the combined length of the strings 
        System.Console.WriteLine (b);
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