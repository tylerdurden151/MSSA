/*
 1. Write a program in C# Sharp to find the +ve numbers from a list of numbers using where conditions in LINQ Query.
Input: { 2, -1, 3, -3, 10, -200}
Expected output: {2, 3, 10}
 */
// The Three Parts of a LINQ Query:
// 1. Data source.
int[] numbers = [2, -1, 3, -3, 10, -200];
Solution result = new Solution();
result.FindPositiveNumbers(numbers);


public class Solution
{
    public void FindPositiveNumbers(int[] numbers)
    {
        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery = from num in numbers
                       where num > 0
                       select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Console.Write("{0,1} ", num);
        }
    }
}
