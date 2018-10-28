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

    // Complete the checkMagazine function below.
    static void checkMagazine (string[] magazine, string[] note) {
        Hashtable hashtable = new Hashtable();
        for (var i = 0; i < magazine.Length; i++ ) {
        hashtable.Add(i, magazine[i]);
        }

        var matchedWords = 0;
        for (var j = 0; j < note.Length; j++) {
            if (hashtable.ContainsValue(note[j])) {
                matchedWords++;
                hashtable.Remove();
            }
        }
        if (matchedWords == note.Length) {
            System.Console.WriteLine("Yes");
        } else {
            System.Console.WriteLine("No");
        }
    }
}