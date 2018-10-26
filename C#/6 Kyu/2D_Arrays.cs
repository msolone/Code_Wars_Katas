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

    // Complete the hourglassSum function below.
    static int hourglassSum (int[][] arr) {
        var total = arr[0][0] + arr[0][1] +
            arr[0][2] + arr[1][1] +
            arr[2][0] + arr[2][1] +
            arr[2][2];
        var placeholder = 0;
        for (var x = 0; x <= 3; x++) {
            for (var y = 0; y <= 3; y++) {

                placeholder = arr[x][y] + arr[x][y + 1] +
                    arr[x][y + 2] + arr[x + 1][y + 1] +
                    arr[x + 2][y] + arr[x + 2][y + 1] +
                    arr[x + 2][y + 2];

                if (placeholder > total) {
                    total = placeholder;
                }
            }
        }
        return total;

    }
}