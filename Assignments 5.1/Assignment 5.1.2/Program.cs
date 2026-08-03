/*
 */
try
{
    Console.WriteLine(Solution.Sum(123));
    Console.WriteLine(Solution.Sum(0));
    Console.WriteLine(Solution.Sum(5342));
    Console.WriteLine(Solution.Sum(-5));  // This will throw
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


public class Solution
{
    public static int Sum(int nums)
    {
        if (nums < 0)
        {
            throw new ArgumentException("Input must be a non-negative integer");
        }

        int sum = 0;
        while (nums > 0)
        {
            int digit = nums % 10;
            nums /= 10;
            sum += digit;
        }
        return sum;
    }
}