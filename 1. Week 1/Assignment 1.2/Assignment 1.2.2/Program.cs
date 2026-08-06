// Assignment 1.2.2
/*Write a C# Sharp program to find the sum of first 10 natural numbers.
Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55
*/
Console.WriteLine("Welcome to the Assignment 1.2.2");
Console.WriteLine("Please enter 10 positive integers, separated by spaces:");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
PrintNumbers(numbers);
static void PrintNumbers(int[] numbers)
{
    int sum = 0;

    for (int i = 0; i < numbers.Length && i < 10; i++)
    {
        if (numbers[i] <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            break;
        }

        Console.WriteLine(numbers[i]);
        sum += numbers[i];
    }

    Console.WriteLine($"The Sum is: {sum}");
}
