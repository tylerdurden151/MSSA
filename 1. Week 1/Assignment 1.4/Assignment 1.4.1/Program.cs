/*Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2. 
 * Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates. 
 * ( if p1.x is more than p2.x , it is to the right )
 */
using System;

// Top-level program: create points, "modify" by creating a new instance, and compare
Point p1 = new Point(10, 20);
Point p2 = new Point(20, 20);


p2.X = 99;

p1.CheckPoints(p1, p2);

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {

        X = x;
        Y = y;
    }
    public void CheckPoints(Point p1, Point p2)
    {
        if (p1.X == p2.X && p1.Y == p2.Y)
        {
            Console.WriteLine("The points are equal.");
        }
        else if (p1.X > p2.X)
        {
            Console.WriteLine("Point 2 is to the left of point 1.");
        }
        else if (p1.X < p2.X)
        {
            Console.WriteLine("Point 2 is to the right of point 1.");
        }
        else
        {
            Console.WriteLine("The points are not equal.");
        }
    }
}


