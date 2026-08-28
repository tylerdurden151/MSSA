// Two Sums

using System.Globalization;

Solution s = new Solution();

int[] arr = new int[] { 15, 11, 7, 2 };
int target = 9;
foreach (int i in s.TwoSum(arr, target))
{
    Console.WriteLine(i);
};

class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int missingValue = target - nums[i];
            if (map.ContainsKey(missingValue))
            {
                return new int[] { map[missingValue], i };
            }
            else
            {
                int keyValue = nums[i];
                map[keyValue] = i;
            }
        }
        return new int[] { };
    }
}