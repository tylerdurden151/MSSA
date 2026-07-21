/*
 3. Create a console application to overload “+” and “-“ operator for adding
the areas of 2 circles and getting their area difference respectively.
 
 */

Circle c1 = new Circle(5);
Circle c2 = new Circle(3);

double sum = c1 + c2;   
double diff = c1 - c2;   

Console.WriteLine($"Sum of areas:        {sum:F2}");
Console.WriteLine($"Difference of areas: {diff:F2}");

public class Circle
{

    private double _radius;
    public double Radius { get { return _radius; } set { _radius = value; } }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    // circleA + circleB  → sum of the two areas
    public static double operator +(Circle a, Circle b)
    {
        return a.Area() + b.Area();
    }

    // circleA - circleB  → difference of the two areas
    public static double operator -(Circle a, Circle b)
    {
        return a.Area() - b.Area();
    }
}