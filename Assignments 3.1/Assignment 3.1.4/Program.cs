/*
 4. Write a function which takes an array as input 
and finds the first occurrence of 2 consecutive 1s and changes their value to 0.

For e.g: Input : [0,2,1,1,9,1,1]

Output: [0,2,0,0,9,1,1]
 */
Solution s = new Solution();
int[] result1 = s.ConsecutiveOnes(new int[] {0,2,1,1,9,1,1});
Array.ForEach(result1, Console.WriteLine);

Solution s1 = new Solution();
Console.WriteLine("Enter your array numbers, separated by spaces: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] result2 = s1.ConsecutiveOnes(numbers);
Array.ForEach(result2, Console.WriteLine);


public class Solution
{
    private int[] _numbers;
    public int[] Numbers { get { return _numbers; } set { _numbers = value; } }

    public int[] ConsecutiveOnes(int[] nums)
    {
        Numbers = nums;
        int[] result = new int[Numbers.Length];
        Array.Copy(Numbers, result, Numbers.Length);

        for (int i = 0; i < Numbers.Length; i++)
        {
            int right = Numbers[i + 1];
            int left = Numbers[i];
            if (left == 1 && right == 1)
            {
                result[i] = 0;
                result[i + 1] = 0;
                break;
            }
        }
        return result;
    }

}
