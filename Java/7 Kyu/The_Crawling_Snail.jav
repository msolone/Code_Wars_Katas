// The snail crawls up the column. During the day it crawls up some distance. During the night she sleeps, so she slides down for some distance (less than crawls up during the day).

// Your function takes three arguments:

// The height of the column (meters)
// The distance that the snail crawls during the day (meters)
// The distance that the snail slides down during the night (meters)
// Calculate number of day when the snail will reach the top of the column.

public class Kata {
    public static int snail(int column, int day, int night) {
    Integer days = 1;
    Integer totalDistance = 0;
      for (Integer i = 0; i < column / (day - night); i++) {
        
        if (totalDistance < column) {
            totalDistance += day;
        } 
        if (totalDistance < column) {
            totalDistance -= night;
            days++;
        }
            
      }
      return days;
    }
}