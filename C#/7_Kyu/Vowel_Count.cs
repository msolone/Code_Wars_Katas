// Return the number (count) of vowels in the given string.
// We will consider a, e, i, o, and u as vowels for this Kata.
// The input string will only consist of lower case letters and/or spaces.

using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {   
        return str.Count(c => "aeiou".Contains(c));
    }
}
