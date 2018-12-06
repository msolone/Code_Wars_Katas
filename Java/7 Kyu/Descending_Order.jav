// Your task is to make a function that can take any non-negative integer as a argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

// Examples:
// Input: 21445 Output: 54421

// Input: 145263 Output: 654321

// Input: 1254859723 Output: 9875543221
import java.util.Arrays;
import java.util.Collections;
public class DescendingOrder {
    public static int sortDesc(final int num) {
        // Convert to an array of strings
        String[] digits = String.valueOf(num).split("");
        // Sort Digits in Descending Order
        Arrays.sort(digits, Collections.reverseOrder());
        // Cast as an Integer the value of a String created by Joining the Digits Array
        return Integer.valueOf(String.join("", digits));
    }
  }