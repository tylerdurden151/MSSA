/*Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

 

Example 1:

Input: nums = [2,2,1]

Output: 1

Example 2:

Input: nums = [4,1,2,1,2]

Output: 4

Example 3:

Input: nums = [1]

Output: 1
 */
int[] nums = { 4, 1, 2, 1, 2 };
int[] nums2 = { 2, 2, 1 };

Solution s = new Solution();
Console.WriteLine(s.FindSingleNumber(nums));
Console.WriteLine(s.FindSingleNumber(nums2));

Solution2 s2 = new Solution2();
Console.WriteLine(s2.FindSingleNumber(nums));
Console.WriteLine(s2.FindSingleNumber(nums2));


public class  Solution
{
    //Looked this one up  bitwise XOR
    public int FindSingleNumber(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;
        }
        return result;
    }
}

public class Solution2
{
    public int FindSingleNumber(int[] nums)
    {
        // Same method as the Contains Duplicate prble problem,
        // but instead of returning true when we find a duplicate,
        // we remove it from the set.
        HashSet<int> seen = new HashSet<int>();
        foreach (int n in nums)
        {
            if (!seen.Add(n)) {
                // was already there -> cancel the pair
                seen.Remove(n);   
            }
        } 
        return seen.Single();
    }
}