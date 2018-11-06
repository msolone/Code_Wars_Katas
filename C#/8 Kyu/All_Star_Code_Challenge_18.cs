using System.Linq;
class Kata

{
    public static int StrCount(string str, string letter)
    {
        // Initial Answer
        int counter = 0;
        var c = Convert.ToChar(letter);
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c) {
                counter++;
            }
        }
        return counter;

        // One Liner
        // return str.Count(c => c == Convert.ToChar(letter));
    }
}


