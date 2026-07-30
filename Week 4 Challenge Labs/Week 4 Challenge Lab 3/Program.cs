/*
 */

char [] a = new char[]{'a', 'b', 'c', 'd', 'e'};
Solution.ReverseArray(a);  


class Solution
{
    public static void ReverseArray(char[] a)           
    {
        Console.WriteLine(string.Join(" ", a));

        //declare pointer variables
        int left = 0;
        int right = a.Length - 1;

        //compare left and
        //right pointer values and swap them
        while (left < right)
        {
            //swap values
            char temp = a[left];
            a[left] = a[right];
            a[right] = temp;
            //increment left pointer and decrement right pointer
            left++;
            right--;
        }
        Console.WriteLine(string.Join(" ", a));

    }
}


