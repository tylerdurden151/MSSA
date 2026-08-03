/*
 * 1. Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:

Input: x = 121

Output: true

Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121

Output: false

Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
 */

Console.WriteLine(Solution.P(121));
Console.WriteLine(Solution.P(-121));

public class Solution
{
    public static bool P(int nums)
    {   
        if (nums < 0)
        {
            return false;
        }
        int original = nums;
        int reversed = 0;

        while (nums > 0)
        {
            reversed = reversed * 10 + nums % 10;
            nums /= 10;
        }
        return reversed == original;
 
    }
}
