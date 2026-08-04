/*
 * 2. Write a program in C# Sharp to print the first n natural number using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
1 2 3 4 5 6 7 8 9 10
 */
Solution s = new Solution();
s.Num(10); 

public class Solution
{
    public void Num(int num)
    {  
        if (num <= 0)
        {
            return;
        }
        Num(num - 1);
        //this is unreachable until the recursion unwinds,
        //so it will print in ascending order
        Console.Write(num + " "); 

    }    
}

