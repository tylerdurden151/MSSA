/*
 Given a string s, reverse only all the vowels in the string and return it.
The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

Example 1:

Input: s = "hello"

Output: "holle"

Example 2:

Input: s = "avacado"

Output: "ovacada"

Example 3: “intelligent”-à   i , e, i, e

Output: entillegint*/
Solution s = new Solution();
s.UserInputArray();

public class Solution
{
    public void UserInputArray()
    {
        Console.WriteLine("Enter the size of the array: ");
        Console.WriteLine();
        int size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine();

        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("The elements of the array are: ");
        Console.WriteLine(string.Join(", ", arr));
        int[] sortedArr = SortMethod(arr);
        Console.WriteLine("The sorted elements of the array are: ");
        Console.WriteLine(string.Join(", ", sortedArr));
    }

    public int[] SortMethod(int[] arr)
    {
        int[] temp = new int[arr.Length];
        void Merger(int left, int right)
        {
            if (left >= right) {
                return;
            }
            int mid = (left + right) / 2;
            Merger(left, mid);
            Merger(mid + 1, right);
            MergeHelper(left, mid, right);
        }
        void MergeHelper(int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];
                }
            }
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }
            for (int l = left; l <= right; l++)
            {
                arr[l] = temp[l];
            }
        }
        Merger(0, arr.Length - 1);
        return arr;
    }

}