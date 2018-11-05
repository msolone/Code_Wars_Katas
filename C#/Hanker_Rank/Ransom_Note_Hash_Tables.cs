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
    // Works but to slow
    // static void checkMagazine (string[] magazine, string[] note) {
    //     Array.Sort (magazine);
    //     Array.Sort (note);
    //     int magLength = magazine.Length;
    //     int noteLength = note.Length;
    //     var matched = 0;
    //     var y = 0;
    //     for (var i = 0; i < magLength; i++) {
    //         if (note[y] == magazine[i]) {
    //             matched++;
    //             y++;
    //         }

    //     }
    //     if (matched == noteLength) {
    //         System.Console.WriteLine ("Yes");
    //     } else {
    //         System.Console.WriteLine ("No");
    //     }
    // }

 
    // Fast enough answer
    static void checkMagazine (string[] magazine, string[] note) {
        Dictionary<string, int> dict = new Dictionary<string, int> ();
        for (var i = 0; i < magazine.Length; i++) {
            if (dict.ContainsKey (magazine[i])) {
                dict[magazine[i]] = dict[magazine[i]] + 1;
            } else {
                dict.Add (magazine[i], 1);
            }
        }
    var answer = "Yes";
        foreach (var item in note) {
            if (dict.ContainsKey (item) && dict[item] > 0) {
                dict[item] = dict[item] - 1;
            } else {
                answer = "No";
            }

        }
        System.Console.WriteLine(answer);
    }

}


