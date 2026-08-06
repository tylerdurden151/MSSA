/*
 5. Create a function that finds the index of a given item in the array

Examples

Search([1, 5, 3], 5) ➞ 1

Search([9, 8, 3], 3) ➞ 2

Search([1, 2, 3], 4) ➞ -1

Notes

If the item is not present, return -1.
 */
Solution s = new Solution(new int[] { 1, 5, 3 }, 5);
Solution s1 = new Solution(new int[] { 9, 8, 3 }, 3);
Solution s2 = new Solution(new int[] { 1, 2, 3 }, 4);
Console.WriteLine(s.Search());    // 1  (5 is at index 1)
Console.WriteLine(s1.Search());   // 2  (3 is at index 2)
Console.WriteLine(s2.Search());   // -1 (4 not present)


public class Solution
{
    private int[] _arr = Array.Empty<int>();
    private int _k;
    public int[] Arr { get { return _arr; } set { _arr = value; } }
    public int K { get { return _k; } set { _k = value; } }

    public Solution(int[] arr, int k)
    {
        Arr = arr;
        K = k;
    }

    public int Search()
    {
        int index = 0;
        foreach (int item in Arr)
        {
            if (item == K)
            {
                return index;
            }
            index++;
        }
        return -1;
    }
}