// HACKER RANK

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

    // Correct but inefficient O(N^2).
    static int[] rotLeft (int[] a, int d) {
        for (var j = 0; j < d; j++) {
            var placeholder = a[0];
            for (var i = 0; i < a.Length - 1; i++) {
                a[i] = a[i + 1];
            }
            a[a.Length - 1] = placeholder;
        }

        return a;
    }

}

class Solution {

    // Creates a circular array O(N)... See Comments Below.
    static int[] rotLeft (int[] a, int d) {
        int[] arr = new int[a.Length];
        for (var i = 0; i < a.Length; i++) {
            var newIndex = (i + d) % a.Length;
            arr[i] = a[newIndex];
        }
        return arr;
    }

}

// # Initial assignments:
//   # array = [1, 2, 3, 4]
//   # length_of_array = array.length = 4
//   # no_of_left_rotation = k = 2
//   # new_arr = Arra.new(length_of_array)
// 	# new_arr: [nil, nil, nil, nil]

// # NOTE:
//   # length_of_array.times do |i|
//     # is equivalent to 
//   # for(i = 0; i < length_of_array; i++)

// # Algorithm to calculate new index and update new array for each index (i):
//   # new_index = (i + no_of_left_rotation) % length_of_array
//   # new_arr[i] = array[new_index]

// # LOOP1:
//   # i = 0
//   # new_index = (0 + 2) % 4 = 2
//   # new_arr[i = 0] = array[new_index = 2] = 3
//   # new_arr: [3, nil, nil, nil]

// # LOOP2:
//   # i = 1
//   # new_index = (1 + 2) % 4 = 3
//   # new_arr[i = 1] = array[new_index = 3] = 4
//   # new_arr: [3, 4, nil, nil]

// # LOOP3:
//   # i = 2
//   # new_index = (2 + 2) % 4 = 0
//   # new_arr[i = 2] = array[new_index = 0] = 1
//   # new_arr: [3, 4, 1, nil]

// # LOOP4:
//   # i = 3
//   # new_index = (3 + 2) % 4 = 1
//   # new_arr[i = 3] = array[new_index = 1] = 2
//   # new_arr: [3, 4, 1, 2]

// # After final loop our new roated array is [3, 4, 1, 2]
// # You can return the output: 
//   # new_arr.join(' ') => 3 4 1 2