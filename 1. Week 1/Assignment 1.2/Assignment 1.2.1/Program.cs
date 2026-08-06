// Assignment 1.2.1
/* Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal
Test Data :
Input 1st number: 5
Input 2nd number: 15
Expected Output :
5 and 15 are not equal
*/

Console.WriteLine("Welcome to the Assignment 1.2.1");
Console.WriteLine("Please enter 2 numbers, separated by spaces:");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
CompareNumbers(numbers);

static void CompareNumbers(int[] numbers)
{
    if (numbers.Length < 2)
    {
        Console.WriteLine("Please enter at least two numbers.");
    }
    else if (numbers[0] > numbers[1])
    {
        Console.WriteLine($"{numbers[0]} is larger.");
    }
    else if (numbers[1] > numbers[0])
    {
        Console.WriteLine($"{numbers[1]} is larger.");
    }
    else
    {
        Console.WriteLine("Both numbers are equal.");
    }
}
