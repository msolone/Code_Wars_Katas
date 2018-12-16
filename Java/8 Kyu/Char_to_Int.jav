// Ask a small girl - "How old are you?". She always says strange things... 
// Lets help her!

// For correct answer program should return int from 0 to 9.

// Assume test input string always valid and may look like 
// "1 year old" or "5 years old", etc.. The first char is number only.


public class CharProblem {
    public static int howOld(final String herOld) {
  
    char[] arr = herOld.toCharArray();
    // toCharArray gives you the numbers in their unicode form
    // To convert an unicode version of a number to its actual 
    // number you must subtract the unicode version of '0' from it.
    return (int)arr[0] - (int)'0';
    
    }

    // Top Answer
    
        public static int howOld(final String herOld) {
        
        return Character.getNumericValue(herOld.charAt(0));
        }
    
  }
