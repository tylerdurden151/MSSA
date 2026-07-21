/*
 4. Write a function that takes 4 numbers as input to calculate the total and average.
(Make use of params array to pass arguments
and out parameters to return both total and average to main method).
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the fourth number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18.75
The total is 75
 
 */
FourNumbers f = new FourNumbers();
f.RunMenu();

FourNumberNew f2 = new FourNumberNew();
FourNumberNew result = f2.CalculateTotalAndAverage(10, 15, 20, 30);
Console.WriteLine($"The average of 10 , 15 , 20 , 30 is: {result.Average}");
Console.WriteLine($"The total is {result.Total}");

public class FourNumbers
{
    private int[] _number = Array.Empty<int>();
    public int[] Number
    {
        get { return _number; }
        set { _number = value; }
    }

    public void RunMenu()
    {
        Number = new int[4];
        for (int i = 0; i < Number.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Please enter a whole number.");
            }
            Number[i] = value;
        }
        int total = CalculateTotal(Number);
        double average = CalculateAverage(Number);
        DisplayResults(total, average);

    }
    private int CalculateTotal(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }
    private double CalculateAverage(params int[] numbers)
    {
        int total = CalculateTotal(numbers);
        return (double)total / numbers.Length;
    }

    private void DisplayResults(int total, double average)
    {
        Console.WriteLine($"The average of {Number[0]} , {Number[1]} , {Number[2]} , {Number[3]} is: {average}");
        Console.WriteLine($"The total is {total}");
    }
}
// Updated code with params array and use a class to return both total
// and average to main method
public class  FourNumberNew
{
    private int[] _number = Array.Empty<int>();
    public int[] Number
    {
        get { return _number; }
        set { _number = value; }
    }
    public int Total { get; set; }
    public double Average { get; set; }


    public void RunMenu()
    {
        Number = new int[4];
        for (int i = 0; i < Number.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Please enter a whole number.");
            }
            Number[i] = value;
        }
        CalculateTotalAndAverage(Number);


    }

    public FourNumberNew CalculateTotalAndAverage(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }
        double average = (double)total / numbers.Length;

        return new FourNumberNew
        {
            Total = total,
            Average = average
        };
    }
}