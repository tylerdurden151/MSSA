/*3. Write a C# Sharp program that takes a number and a width also a number, as input 
 * and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output:

666666

66666

6666

666

66

6
 */

Triangle triangle = new Triangle();
triangle.Run();

class Triangle
{
    private int _number;
    private int _width;
    public int Number
    {
        get { return _number; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Number cannot be negative.");
            }
            _number = value;
        }
    }
    public int Width
    {
        get { return _width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width cannot be negative.");
            }
            _width = value;
        }
    }


    public void Run()
    {
        Console.Write("Enter a number: ");
        Number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the desired width: ");
        Width = Convert.ToInt32(Console.ReadLine());
        DisplayTriangle(Number, Width);
    }
    private void DisplayTriangle(int number, int width)
    {
        for (int i = width; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(number);
            }
            Console.WriteLine();
        }
    }
}