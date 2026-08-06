/*
 Write a program in C# Sharp to display the individual digits of a given number using recursion.
Test Data :
Input any number : 1234
Expected Output :
The digits in the number 1234 are : 1 2 3 4
*/
Solution s = new Solution();
Console.WriteLine($"Number of digits in 12345:");
s.Digits(12345);

public class Solution
{
    public void Digits(int num)
    {
        if (num <= 0)
        {
            return ;
        }

        Digits(num / 10);
        Console.Write((num % 10) + " ");


    }
}