/*You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

 

Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
Example 2:

Input: nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
Explanation: The arrays we are merging are [1] and [].
The result of the merge is [1].
Example 3:

Input: nums1 = [0], m = 0, nums2 = [1], n = 1
Output: [1]
Explanation: The arrays we are merging are [] and [1].
The result of the merge is [1].
Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.*/

Solution result = new Solution();
int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
int m = 3;
int[] nums2 = new int[] { 2, 5, 6 };
int n = 3;
result.Merge(nums1, m, nums2, n);

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        //assign to read for nums1
        int read1 = m - 1;
        //assign to read for nums2
        int read2 = n - 1;
        int write = m + n - 1;
        //Since we are storing only in nums1 we need to just loop thru
        //nums2 read
        while (read2 >= 0)
        {
            //if read 1 isn't zero and and read1 is higher add read1 to write
            if (read1 >= 0 && nums1[read1] > nums2[read2])
            {
                nums1[write] = nums1[read1];
                read1--;
            }
            else
            {
                //read2 is higher add read2 to write
                nums1[write] = nums2[read2];
                read2--;
            }
            write--;
        }
        Console.WriteLine(string.Join(",", nums1));
    }
}
