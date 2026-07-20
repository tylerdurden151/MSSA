/*
 4. Write a function which takes an array as input 
and finds the first occurrence of 2 consecutive 1s and changes their value to 0.

For e.g: Input : [0,2,1,1,9,1,1]

Output: [0,2,0,0,9,1,1]
 */

public class Solution
{
    public int[] ConsecutiveOnes(int[] nums)
    {
        int left = 0;
        int curr = 0;
        int[] result = new int[nums.Length];

        for (int right = 0; right < nums.Length; right++) {
            if (nums[right] == 1)
            {
                curr++;
            }
            while (curr > 1)
            {
                if (nums[left] == 1)
                {
                    curr--;
                }
                left++;
            }
            result[curr] = curr;


}
