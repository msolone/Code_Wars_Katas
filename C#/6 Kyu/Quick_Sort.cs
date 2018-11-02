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

    // Complete the maximumToys function below.
    // Initiate Quick Sort by calling it recursively
    public static void quicksort (int[] array) {
        quicksort (array, 0, array.Length - 1);
    }
    // Determine pivot, and quick sort each partition seperately
    public static void quicksort (int[] array, int left, int right) {
        // If the left passes right we stop
        if (left >= right) {
            return;
        }
        // setting pivot to middle
        int pivot = array[left + (right - left) / 2];
        // calling partition to return the index of the new pivot
        int index = partition (array, left, right, pivot);
        // Quick Sort Left Side
        quicksort (array, left, index - 1);
        // Quick Sort Right Side
        quicksort (array, index, right);
    }

    public static int partition (int[] array, int left, int right, int pivot) {
        // Before partition is sorted
        while (left <= right) {
            // if the value at this index is less then pivot, move on, it doesnt need to be swapped
            while (array[left] < pivot) {
                left++;
            }
            // if the value at this index is greater then pivot, move, it doesnt need to be swapped
            while (array[right] > pivot) {
                right--;
            }
            // Swapping places with placeholder
            if (left <= right) {
                var placeholder = left;
                left = right;
                right = placeholder;
                left++;
                right--;
            }
        }
        return left;
    }

}