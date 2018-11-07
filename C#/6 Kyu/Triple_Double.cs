//which takes in numbers num1 and num2 and returns 1 if there is a straight triple of a number at any place in num1 and also a straight double of the same number in num2.
// For example:
// TripleDouble(451999277, 41177722899) == 1 // num1 has straight triple 999s and 
//                                           // num2 has straight double 99s

// TripleDouble(1222345, 12345) == 0 // num1 has straight triple 2s but num2 has only a single 2

// TripleDouble(12345, 12345) == 0

// TripleDouble(666789, 12345667) == 1
// If this isn't the case, return 0

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int TripleDouble(long num1, long num2)
  {
    var numOneArr = num1.ToString();
     System.Console.WriteLine("num1 = " + numOneArr);
    var numTwoArr = num2.ToString();
     System.Console.WriteLine("num2 = " + numTwoArr);

    List<char> triple = new List<char>();
    for (var i = 0;  i < numOneArr.Length - 2; i++) {
        if (numOneArr[i] == numOneArr[i + 1] && numOneArr[i + 1] == numOneArr[i + 2]) {
            triple.Add(numOneArr[i]);
        }
    }
    var answer = 0;
    for (var j = 0; j < numTwoArr.Length - 1; j++) {
       System.Console.WriteLine("Number in Loop = " + numTwoArr[j]);
        if (numTwoArr[j] == numTwoArr[j + 1] && triple.Contains(numTwoArr[j])) {
               
                answer = 1;
        }
    }
    
    foreach (var item in triple)
    {
        System.Console.WriteLine("Triple = " + item);
    }
    System.Console.WriteLine("Answer = " + answer);
    return answer;
    
  }
}
