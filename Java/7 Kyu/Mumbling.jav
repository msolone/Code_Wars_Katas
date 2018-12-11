// This time no story, no theory. The examples below show you how to write function accum:

// Examples:

// accum("abcd") -> "A-Bb-Ccc-Dddd"
// accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
// accum("cwAt") -> "C-Ww-Aaa-Tttt"
// The parameter of accum is a string which includes only letters from a..z and A..Z.


public class Accumul {
    public static String accum(String s) {
      StringBuilder bldr = new StringBuilder();
      int i = 0;
      // Loop through an character array created from s
      for(char c : s.toCharArray()) {
        // Add a "-" if "i" is greated then 0;
        if(i > 0) bldr.append('-');
        // Changes the first character to an uppercase
        bldr.append(Character.toUpperCase(c));
        // Based on the index of the current letter in the original
        // string, the letter is repeated in lowercase
        for(int j = 0; j < i; j++) bldr.append(Character.toLowerCase(c));
        i++;
      }
      return bldr.toString();
    }
  }