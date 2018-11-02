using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        numberOfOnes(5);

    }
    public static int numberOfOnes(int n) {
        int onesCount = 0;
        var binary = Convert.ToString(n, 2);
        System.Console.WriteLine(binary);
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == "1") {
                onesCount++;
            }
        }
        return onesCount;

    }
}