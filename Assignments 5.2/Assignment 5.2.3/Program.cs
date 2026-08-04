/*3. Write a program in C# Sharp to print numbers from 
 * n to 1 using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
10 9 8 7 6 5 4 3 2 1
 
 */

Solution s = new Solution();
s.Num(10); // Output: 10 9 8 7 6 5 4 3 2 1

public class Solution
{
    public void Num(int num)
    {

        if (num <= 0)
        {
            return;
        }
        Console.Write(num + " ");
        Num(num - 1);g

    }
}