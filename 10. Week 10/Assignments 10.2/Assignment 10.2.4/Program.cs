/*4. Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
Test Data :
The members of the list are :
55 200 740 76 230 482 95
Expected Output :
The numbers greater than 80 are :
200
740
230
482
95
 */

Solution result = new Solution();
result.FindNumbersGreaterThan80(new List<int> { 55, 200, 740, 76, 230, 482, 95 });

public class  Solution
{
    public void FindNumbersGreaterThan80(List<int> numbers)
    {
        // LINQ query to find numbers greater than 80
        var numberQuery = from num in numbers
                          where num > 80
                          select num;
        // Display the filtered numbers
        Console.WriteLine("The numbers greater than 80 are :");
        foreach (var num in numberQuery)
        {
            Console.WriteLine(num);
        }
    }
}