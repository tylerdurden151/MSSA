/*3. Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .

Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.

Inherit square class from shape and change the calculate area logic. Add property like side of square.

Take the input from user to select circle or square and display the calculated area . no hard coded values!
 */
Console.WriteLine("Welcome to Assignment 2.2.3");
int choice = PrintMenu();

switch (choice)
{
    case 1:
        Circle circle = CreateCircle();
        Console.WriteLine($"The area of the circle is: {circle.CalculateArea()}");
        break;

    case 2:
        Square square = CreateSquare();
        Console.WriteLine($"The area of the square is: {square.CalculateArea()}");
        break;
    default:
        Console.WriteLine("Invalid choice. Please try again.");
        break;
}

static int PrintMenu()
{
    Console.WriteLine("Please select the shape to calculate area:");
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    return choice;
}

static Circle CreateCircle()
{
    Console.WriteLine("Enter ID: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Color: ");
    string color = Console.ReadLine();
    Console.WriteLine("Enter Radius: ");
    double radius = Convert.ToDouble(Console.ReadLine());

    return new Circle(id, name, color, radius);
}
static Square CreateSquare()
{
    Console.WriteLine("Enter ID: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Color: ");
    string color = Console.ReadLine();
    Console.WriteLine("Enter Side Length: ");
    double side = Convert.ToDouble(Console.ReadLine());
    return new Square(id, name, color, side);
}

public abstract class Shape
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public abstract double CalculateArea();
    
    public Shape (int id, string name, string color)
    {
        Id = id;
        Name = name;
        Color = color;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(int id, string name, string color, double radius) : base(id, name, color)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Square : Shape
{
    public double Side { get; set; }
    public Square(int id, string name, string color, double side) : base(id, name, color)
    {
        Side = side;
    }
    public override double CalculateArea()
    {
        return Side * Side;
    }
}
