/**/
Solution s = new Solution();
Console.WriteLine(s.anaGram("aab", "aba")); // Output: true
Console.WriteLine(s.anaGram("aab", "abb")); // Output: false



public class Solution
{
    public bool anaGram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (sDict.ContainsKey(c))
            {
                sDict[c]++;
            }
            else
            {
                sDict[c] = 1;
            }
        }
        foreach (char c in t)
        {
            if (!sDict.ContainsKey(c))
            {
                return false;
            }

            sDict[c]--;

            if (sDict[c] < 0)
            {
                return false;
            }
        }
        return true;
    }

    //Wont work for duplicate characters in the string. For example, "aab" and "aba" will return false.
    public bool anaGram1(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (!s.Contains(t[i]))
            {
                return false;
            }
        }
        return true;
    }
}