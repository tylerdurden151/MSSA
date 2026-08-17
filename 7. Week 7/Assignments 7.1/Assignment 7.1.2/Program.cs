/**/
Solution s = new Solution();
string word1 = "abc";
string word2 = "pqr";
Console.WriteLine(s.MergeAlternately(word1,word2));


public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        //strings are immutable
        char[] result = new char[word1.Length + word2.Length];
        int word1pos = 0;
        int word2pos = 0;
        int pos = 0;

        while (word1pos < word1.Length || word2pos < word2.Length) {
            if (word1pos < word1.Length)
            {
                result[pos++] = word1[word1pos++];
            }
            if (word2pos < word2.Length)
            {
                result[pos++] = word2[word2pos++];
            }
        
        }
        return new string(result);
    }
 }