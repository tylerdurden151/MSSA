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
        switch ((x, y))
        {
            case (0, 0):
                Console.WriteLine($"The coordinate point ({x},{y}) is at the origin.");
                break;
            case (0, _):
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y axis.");
                break;
            case (_, 0):
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X axis.");
                break;
            case ( > 0, > 0):
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
                break;
            case ( < 0, > 0):
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
                break;
            case ( < 0, < 0):
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
                break;
            case ( > 0, < 0):
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
                break;
        }
    }
}