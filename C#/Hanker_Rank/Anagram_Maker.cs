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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        int combinedLength = a.Length + b.Length;
        int sharedLetters = 0;
        // Loop through determing the letters in "a" that are contained in "b"
        for (int i = 0; i < a.Length; i++) {
        // If they are in both, add 2 to the sharedLetters
            if (b.Contains(a[i])) {
                sharedLetters += 2;
                b.Remove(b.IndexOf(a[i]), 1);
            }
        }
        // Subtract sharedLetters from the combined length of the strings 
        System.Console.WriteLine(b);
        return combinedLength - sharedLetters;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
