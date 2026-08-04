/*
 */

Solution s = new Solution();
Console.WriteLine(s.MissingNumber(new int[] { 3, 0, 1 }));
Console.WriteLine(s.MissingNumber(new int[] { 0, 1 }));
Console.WriteLine(s.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));

class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        foreach (int num in nums)
        {
            actualSum += num;
        }
        return expectedSum - actualSum;
    }
}