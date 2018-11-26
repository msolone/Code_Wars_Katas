// In this kata you should simply determine, whether a given year is a leap year or not. In case you don't know the rules, here they are:

// years divisible by 4 are leap years
// but years divisible by 100 are no leap years
// but years divisible by 400 are leap years
// Additional Notes:

// Only valid years (positive integers) will be tested, so you don't have to validate them

using System;

public static class Kata {
    public static bool IsLeapYear (int year) {
        // return year % 4 == 0 || year % 400 == 0 ? true :  false; 
        if (year % 4 == 0) {
            if (year % 100 == 0 && year % 400 != 0) {
                return false;
            } else if (year % 100 == 0 && year % 400 == 0) {
                return true;
            } else {
                return true;
            }
        } else {
            return false;
        }
    }
}