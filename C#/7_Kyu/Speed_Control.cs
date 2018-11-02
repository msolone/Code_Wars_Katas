// In John's car the GPS records every s seconds the distance travelled from an origin (distances are measured in an arbitrary but consistent unit). For example, below is part of a record with s = 15:

// x = [0.0, 0.19, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25]
// The sections are:

// 0.0-0.19, 0.19-0.5, 0.5-0.75, 0.75-1.0, 1.0-1.25, 1.25-1.50, 1.5-1.75, 1.75-2.0, 2.0-2.25
// We can calculate John's average hourly speed on every section and we get:

// [45.6, 74.4, 60.0, 60.0, 60.0, 60.0, 60.0, 60.0, 60.0]
// Given s and x the task is to return as an integer the *floor* of the maximum average speed per hour obtained on the sections of x. If x length is less than or equal to 1 return 0 since the car didn't move.

// #Example: with the above data your function gps(x, s)should return 74

// Note
// With floats it can happen that results depends on the operations order. To calculate hourly speed you can use:

// (3600 * delta_distance) / s.

using System;
using System.Linq;

// My Answer
public class GpsSpeed {

    public static int Gps (int s, double[] x) {
        if (x.Length <= 1) {
            return 0;
        } else {
            var avg = x.Skip(1).Select((distance, index) => ((distance - x[index]) * 3600) / s);
            return (int)Math.Floor(avg.Max());
        }

    }
}

// 1 Liner
public class GpsSpeed {

    public static int Gps (int s, double[] x) {
    
    return x.Length <= 1 ? 0 : (int)Math.Floor((x.Skip(1).
                                      Select((distance, index) => ((distance - x[index]) * 3600) / s))
                                          .Max()); 
    }
}

// Top Answer
public class GpsSpeed 
{
    public static int Gps(int s, double[] x) 
    {
      if(x.Length > 2)
      {
        var averageSpeeds = x.Skip(1).Select((distance, index) => ((distance - x[index]) / s) * 3600);
        return Convert.ToInt32(Math.Floor(averageSpeeds.Max()));
      }
      
      return 0;
    }
}