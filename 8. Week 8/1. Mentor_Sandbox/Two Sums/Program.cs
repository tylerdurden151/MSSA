// Two Sums

using System.Globalization;

Solution s = new Solution();

int[] result1 = s.TwoSum(new int[] { -4, -1, 0, 3, 10 });
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
            int missing = target - nums[i];
            if (map.ContainsKey(missing))
            {
                return new int[] { map[missing], i };
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