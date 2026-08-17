/*
 You are a student who has recently taken an exam with your classmates. 
However, the professor has not yet provided the students with a sorted list of exam scores.
To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm. 
This way, you can obtain the sorted list of scores and see how you performed compared to your classmates.
Also, you choose selection sort since that is an easy way of implementation.
 
 */

Solution s = new Solution();
int[] result = s.GradedScore(new int[] { 88, 90, 77, 100 });
Console.WriteLine(string.Join(", ", result));

public class Solution
{
    public int[] GradedScore(int[] scores) {
        for (int i = 0; i < scores.Length; i++)
        {
            int max = i;
            for (int j = i + 1; j < scores.Length; j++) { 
            
                if (scores[j] < scores[max])
                {
                    max = j;
                }
            }

           (scores[max], scores[i]) = (scores[i], scores[max]);

        }
        return scores;

    }
}