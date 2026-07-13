// Assignment 1.2.3
/* Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division.
 * Call them appropriately when user selects the option. 
 * Give the user the option to continue or exit the program.*/
Console.WriteLine("Welcome to the Assignment 1.2.3");

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
                Console.WriteLine($"The result of addition is: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"The result of subtraction is: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"The result of multiplication is: {num1 * num2}");
                break;
            case 4:
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine($"The result of division is: {num1 / num2}");
                }
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
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit:");
}

