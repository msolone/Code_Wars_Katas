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

    // Complete the twoStrings function below.
    // Compare is two string share a common substring
    static string twoStrings(string s1, string s2) {
        var answer = "No";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (var i = 0; i < s1.Length; i++) 

        {
            if (dict.ContainsKey(s1[i])) 
            {
                dict[s1[i]] = dict[s1[i]] + 1;
            } 
            else 
            {
                dict.Add(s1[i], 1);
            }
            
        }

        for (var j = 0; j < s2.Length; j++) 
        {
            if (dict.ContainsKey(s2[j])) 
            {
                answer = "Yes";
            }
        }

        return answer;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
