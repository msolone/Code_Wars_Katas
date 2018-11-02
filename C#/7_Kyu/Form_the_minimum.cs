using System;
using System.Linq;
using System.Collections.Generic;
class Kata
{
    public static long MinValue(int[] arr)
    {
        Array.Sort(arr);
        var newList = arr.Distinct().Reverse();
        var counter = 0;
        var number = 0.0;
        
        foreach (int num in newList)
        {
        number += ((double)num * Math.Pow(10, counter));
        counter++;
        }
        
        return (long)number;

    } 
}