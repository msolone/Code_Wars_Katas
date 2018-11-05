  using System.Collections.Generic; 
  using System;


// My Answer
  public class Kata {
      public static string AlphabetWar (string fight) {
          int right = 0;
          int left = 0;
          foreach (var letter in fight) {
              if (letter == 'm') {
                  right += 4;
              } else if (letter == 'q') {
                  right += 3;
              } else if (letter == 'd') {
                  right += 2;
              } else if (letter == 'z') {
                  right += 1;
              } else if (letter == 'w') {
                  left += 4;
              } else if (letter == 'p') {
                  left += 3;
              } else if (letter == 'b') {
                  left += 2;
              } else if (letter == 's') {
                  left += 1;
              }
          }
          if (right > left) {
              return "Right side wins!";
          } else if (left > right) {
              return "Left side wins!";
          } else {
              return "Let's fight again!";
          }
      }
  }

  // Top Answer ** Nice use of Dictionary, could also use Switch statement
 public class Kata
 {
    public static string AlphabetWar(string fight)
    {
      var numVal = new Dictionary<char, int>()
      {
          {'w', 4 },
          {'p', 3 },
          {'b', 2 },
          {'s', 1 },
          {'m', -4 },
          {'q', -3 },
          {'d', -2 },
          {'z', -1 }
      };

      int score = 0;
      
      foreach (var letter in fight)
          {
              if (numVal.ContainsKey(letter))
                  score += numVal[letter];
          }

      if (score > 0)
          return "Left side wins!";
      else if (score == 0)
          return "Let's fight again!";
      else
          return "Right side wins!";
    }
 }