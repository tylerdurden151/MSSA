/*Write a program in C# to calculate area of triangle, square and rectangle. 
 * Write 3 different functions for each shape to take dimensions of figure and display the area. 
 * You may create menus.
 */


using System.Drawing;

Console.WriteLine("Welcome to Assignment 1.3.1");
PrintMenu();

static void PrintMenu()
{
    Console.WriteLine("Please select an option from the menu below:");
    Console.WriteLine("1.) Calculate the area of a rectangle");
    Console.WriteLine("2.) Calculate the area of a triangle");
    Console.WriteLine("3.) Calculate the area of a Square");
    Console.WriteLine("4.) Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    Selection(choice);
}

static void Selection(int choice)
{
    while (true)
        switch (choice)
        {
            case 1:
                Rectangle();
                PrintMenu();
                break;
            case 2:
                Triangle();
                PrintMenu();
                break;
            case 3:
                Square();
                PrintMenu();
                break;
            case 4:
                Console.WriteLine("Exiting the program. Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }
}


static void Rectangle()
{
    Console.WriteLine("You selected option 1: Calculate the area of a rectangle");
    Console.WriteLine("Please enter the length of the rectangle:");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter the width of the rectangle:");
    double width = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"The area of the rectangle is: {length * width}");
}

static void Triangle()
{
    Console.WriteLine("You selected option 2: Calculate the area of a triangle");
    Console.WriteLine("Please enter the base of the triangle:");
    double baseLength = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter the height of the triangle:");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"The area of the triangle is: {0.5 * baseLength * height}");
}

static void Square()
{
    Console.WriteLine("You selected option 3: Calculate the area of a square");
    Console.WriteLine("Please enter the length of one side of the square:");
    double sideLength = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"The area of the square is: {sideLength * sideLength}");
}
