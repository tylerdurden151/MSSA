/*
 1. Given a string, write a method that checks 

if it is a palindrome (is read the same backward as forward). 

Assume that string may consist only of lower-case letters.

Expected input and output

IsPalindrome("eye") → true

IsPalindrome("home") → false
 
 */

var result = IsPalindrome("eye");
var result2 = IsPalindrome("home");
Console.WriteLine(result);
Console.WriteLine(result2);


var result3 = IsPalindromeStreamlined("School");
Console.WriteLine(result3);

bool IsPalindrome(string p) {
    p = p.ToLower();
    char [] chars = p.ToCharArray();
    int left = 0;
    int right = chars.Length - 1;

    while (left < right)
    {
        char temp = chars[left];
        chars[left] = chars[right];
        chars[right] = temp;
        right--;
        left++;
    }
    if (new string(chars) == p)
    {
        return true;
    }
    return false;
}
//Here is the a O(1) -- Alot better
bool IsPalindromeStreamlined(string p)
{
    p = p.ToLower();
    int left = 0;
    int right = p.Length - 1;

    while (left < right)
    {
        if (p[left] != p[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}