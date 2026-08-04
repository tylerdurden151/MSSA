/**
 * 4. Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
Test Data :
Input a string : RADAR
Expected Output :
The string is Palindrome.
 */

Solution s = new Solution();
Console.WriteLine(s.IsPalindrome("RADAR")); // Output: True
Console.WriteLine(s.IsPalindrome("RACECAR")); 
Console.WriteLine(s.IsPalindrome("hello")); // Output: False
Console.WriteLine(s.IsPalindromeNoRecursion("RADAR")); // Output: True

public class Solution
{
    public bool IsPalindrome(string s, int left = 0, int right = -1)
    {
        if (right == -1) {
            right = s.Length - 1;
        }

        if (left >= right)
        {
            return true;
        }
        if (s[left] != s[right]) {
            return false;
        }

        return IsPalindrome(s, left + 1, right - 1);  
    }


    public bool IsPalindromeNoRecursion(string s)
    {
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
           result += s[i];  
        }
        return result == s;
    }

}