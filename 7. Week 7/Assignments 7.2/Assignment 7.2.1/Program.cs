/**/


Solution s = new Solution();
Console.WriteLine(s.ReverseString("hello")); // Output: "holle"
Console.WriteLine(s.ReverseString("avacado")); // Output: "avadoca"
Console.WriteLine(s.ReverseString("intelligent")); // Output: "telligne"


class Solution
{
    public string ReverseString(string s)
    {
        char[] sChar = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;
        string vowels = "aeiouAEIOU";
        while (left < right)
        {
            while (left < right && !vowels.Contains(sChar[left]))
            {
                left++;
            }
            while (left < right && !vowels.Contains(sChar[right]))
            {
                right--;
              
            }
           if (left < right) {
                char temp = sChar[left];
                sChar[left] = sChar[right];
                sChar[right] = temp;
                left++;
                right--;
            }
        }

        return new string(sChar);
    }
}