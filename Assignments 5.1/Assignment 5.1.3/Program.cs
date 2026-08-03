/*
 
 */

using System;
Solution s = new Solution();
bool result1 = s.isTwice(new int[] { 1, 2, 3, 4, 5 });
bool result2 = s.isTwice(new int[] { 1, 2, 3, 1 });
bool result3 = s.isTwice(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);



public class Solution
{
    public bool isTwice(int[] num)
    {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        foreach( int i in num ) {
            if( countMap.ContainsKey( i ) ) {
                countMap[ i ]++;
            } else {
                countMap[ i ] = 1;
            }
        }

        foreach( var kvp in countMap ) {
            if( kvp.Value == 2 ) {
                return true;
            }
        }

        return false;   
    }

}