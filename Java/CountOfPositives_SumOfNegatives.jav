public class Kata
{
    public static int[] countPositivesSumNegatives(int[] input)
    {
        int[] answer = new int[2];
        Integer countOfPositives = 0;
        Integer sumOfNegatives = 0;
        // Only runs loop if input is not empty or null
        if (input != null && input.length != 0 ) {

            for (Integer i = 0; i < input.length; i++ ) {
                if (input[i] > 0) {
                    countOfPositives++;
                } else {
                    sumOfNegatives += input[i];
                }
            }
            answer[0] = countOfPositives;
            answer[1] = sumOfNegatives;
            return answer;
        // If input is empty or null, then return an empty array
        } else {
            int[] emptyNullAnswer= {};
            return emptyNullAnswer;
        }

    }
}