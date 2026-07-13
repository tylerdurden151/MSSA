/*
 * 2. Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). 
 * Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static.
 */

Console.WriteLine("Welcome to the Assignment 2.2.2");

Console.WriteLine("Welcome to Calculator application.");

CalculatorFunction();

static void CalculatorFunction()
{

    while (true)
    {
        PrintMenu();
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 5)
        {
            Console.WriteLine("Exiting the application.");
            return;
        }
        Console.WriteLine("Please enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        switch (choice)
        {
            case 1:
                int value1 = Maths.Add((int)num1, (int)num2);
                Console.WriteLine($"The result of addition is: {value1}");
                break;
            case 2:
                Console.WriteLine("Please enter the third number:");
                double num3 = Convert.ToDouble(Console.ReadLine());
                decimal value2 = Maths.Add((decimal)num1, (decimal)num2, (decimal)num3);
                Console.WriteLine($"The result of addition is: {value2}");
                break;
            case 3:
                float value3 = Maths.Multiply((float)num1, (float)num2);
                Console.WriteLine($"The result of multiplication is: {value3}");
                break;
            case 4:
                Console.WriteLine("Please enter the third number:");
                double num3b = Convert.ToDouble(Console.ReadLine());
                float value4 = Maths.Multiply((float)num1, (float)num2, (float)num3b);
                Console.WriteLine($"The result of multiplication is: {value4}");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        Console.WriteLine();
    }
}

static void PrintMenu()
{
    Console.WriteLine("Please enter if you want to add, subtract, multiply or divide two numbers.");
    Console.WriteLine("1. Add 2 values");
    Console.WriteLine("2. Add 3 values");
    Console.WriteLine("3. Multiply 2 values");
    Console.WriteLine("4. Multiply 3 values");
    Console.WriteLine("5. Exit:");
}