/*
 1. Create a 2D array to store integers 

and print them in matrix format with proper formatting.

e. g:

| 2 | 3 | 4 |

| 1 | 4 | 6 |
 */
int[] value = { 2, 3, 4, 1, 4, 6 };

TwoDArray t = new TwoDArray(value);
t.DisplayTwoD();

public class TwoDArray
{
    private int[] _number = Array.Empty<int>();
    public int[] Number { get { return _number; } set { _number = value; } }

    public TwoDArray(int[] nums)
    {
        Number = nums;
    }

    public void DisplayTwoD()
    {
        int count = 0;
        foreach (int n in Number)
        {
            //New line | 
            if (count % 3 == 0)
            {
                Console.Write("|");
            }
            Console.Write($" {n} |");
            count++;
            //Break line up to 3 values
            if (count % 3 == 0)
            {
                Console.WriteLine();
            }
        }
    }
} 