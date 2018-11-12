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

    // Complete the luckBalance function below.
    static int luckBalance (int k, int[][] contests) {
        var sorted = contests.OrderBy (x => x[0]).ToList ();

        var unimportant = 0;
        var important = 0;
        for (var i = 0; i < contests.Length; i++) {
            System.Console.WriteLine ($"({sorted[i][0]},{sorted[i][1]})");

            if (sorted[i][1] == 0) {
                unimportant++;
            } else {
                important++;
            }
        }
        System.Console.WriteLine ("Total Losses Allowed: " + k);
        System.Console.WriteLine ("Total Important Contest: " + important);
        System.Console.WriteLine ("Total Unimportant Contest: " + unimportant);
        var importantWinsNeeded = important - k;
        System.Console.WriteLine ("Important Wins Needed: " + importantWinsNeeded);

        var totalWins = 0;
        var luckPoints = 0;
        for (var j = 0; j < contests.Length; j++) {
            if (sorted[j][1] == 1 && totalWins < importantWinsNeeded) {
                luckPoints -= sorted[j][0];
                totalWins++;
            } else {
                luckPoints += sorted[j][0];
            }
        }
        System.Console.WriteLine ("Total Luck Points: " + luckPoints);
        return luckPoints;
    }

    static void Main (string[] args) {
        TextWriter textWriter = new StreamWriter (@System.Environment.GetEnvironmentVariable ("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine ().Split (' ');

        int n = Convert.ToInt32 (nk[0]);

        int k = Convert.ToInt32 (nk[1]);

        int[][] contests = new int[n][];

        for (int i = 0; i < n; i++) {
            contests[i] = Array.ConvertAll (Console.ReadLine ().Split (' '), contestsTemp => Convert.ToInt32 (contestsTemp));
        }

        int result = luckBalance (k, contests);

        textWriter.WriteLine (result);

        textWriter.Flush ();
        textWriter.Close ();
    }
}