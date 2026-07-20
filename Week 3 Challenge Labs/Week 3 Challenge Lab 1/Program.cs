/*
 1. Given a string, write a method that checks 

if it is a palindrome (is read the same backward as forward). 

Assume that string may consist only of lower-case letters.

Expected input and output

IsPalindrome("eye") → true

IsPalindrome("home") → false
 
 */

var result = IsPalindrome("stoots");
Console.WriteLine(result);

bool IsPalindrome(string p) {
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
    if (chars.ToString() == p)
    {
        return true;
    }
    return false;
}