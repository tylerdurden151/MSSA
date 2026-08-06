/***
 * This program calculates the Fibonacci sequence using both recursive
 * and iterative approaches.
 */
int val1 = 0;
int val2 = 1;
int n = 8;
FibonacciIterative.FibonacciI(val1, val2, n);

FibonacciRecursive f = new FibonacciRecursive();
Console.WriteLine();
Console.WriteLine("Fibonacci series using recursive approach:");
for (int i = 0; i < n; i++)
{
    Console.Write(f.FibonacciR(i) + " ");
}

public class FibonacciRecursive
{
    public int FibonacciR(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return FibonacciR(n - 1) + FibonacciR(n - 2);
    }
}

public class FibonacciIterative
{
   public static void FibonacciI(int val1, int val2, int n)
    {
        int val3 = 0;
        
        Console.WriteLine(val1 + " " + val2 + " ");
        Console.WriteLine();
        Console.WriteLine("Fibonacci series using iterative approach:");
        for (int i = 2; i < n; i++)
        {
            val3 = val1 + val2;
            Console.Write(val3 + " ");
            val1 = val2;
            val2 = val3;
        }
        
    }
}
