/*
 3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

Test Data :

Input the value for X coordinate :7

Input the value for Y coordinate :9

Expected Output :

The coordinate point (7,9) lies in the First quadrant.
 */

Point point = new Point();
point.Run();

public class Point
{
    private int _x; 
    private int _y;
    public int X { get { return _x; } set { _x = value; } }
    public int Y { get { return _y; } set { _y = value; } }

    public void Run()
    {
        Console.WriteLine("Input the value for X coordinate :");
        X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the value for Y coordinate :");
        Y = Convert.ToInt32(Console.ReadLine());
        Quadrant(X, Y);
    }

    public void Quadrant(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y axis.");
        }
        else if (y == 0 && x != 0)
        {
            Console.WriteLine($"The coordinate point ({x},{y}) lies on the X axis.");
        }
        else
        {
            Console.WriteLine($"The coordinate point ({x},{y}) is at the origin.");
        }
    }
}