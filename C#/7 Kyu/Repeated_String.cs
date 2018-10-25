// Lilah has a string, , of lowercase English letters that she repeated infinitely many times.
// Given an integer, , find and print the number of letter a's in the first  letters of Lilah's infinite string.
// For example, if the string  and , the substring we consider is , the first  characters of her infinite string. There are  occurrences of a in the substring.
// Function Description
// Complete the repeatedString function in the editor below. It should return an integer representing the number of occurrences of a in the prefix of length  in the infinitely repeating string.
// repeatedString has the following parameter(s):
// s: a string to repeat
// n: the number of characters to consider
// Input Format
// The first line contains a single string, . 
// The second line contains an integer, 

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
    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        if (s.Length == 1) {
            return n;
        } else {
        var aCount = 0;
        var timesToRepeat = (int)((n / s.Length) + 1);
        var repeated = string.Concat(Enumerable.Repeat(s, timesToRepeat));
            for (var i = 0; i < n; i++) {
            if (repeated[i] == 'a') {
                aCount++;
            }
          }
            return aCount;
        }
        
    }
}