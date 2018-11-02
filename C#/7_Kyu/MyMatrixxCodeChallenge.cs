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

class Result {
    public static int countUneatenLeaves (int n, List<int> a) {
        
        var leavesLeft = n;
        for (var i = 1; i <= n; i++) {
            if (i % a[2] == 0 || i % a[3] == 0 || i % a[4] == 0) {
                leavesLeft--;
            }
            return leavesLeft;
        }
    }
}