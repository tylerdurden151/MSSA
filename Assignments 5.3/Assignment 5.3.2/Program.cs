/**/
Solution s = new Solution();
Console.WriteLine(s.S(2));
Console.WriteLine(s.S(3));
Console.WriteLine(s.S(4));



public class Solution
{
    public int S(int n)
    {
        //Same as Fibonacci sequence, but validating the input to be greater than 2,
        //since the first two numbers are 1 and 2.
        if (n <= 2){ 
            return n;
        }
        //Same as Fibonacci sequence, but starting with 1 and 2 instead of 0 and 1
        int fib1 = 1 ;
        int fib2 = 2;
        //Same as Fibonacci sequence, but starting 3 instead of 2
        for (int i = 3; i <= n; i++)
        {
            int temp = fib1 + fib2;
            fib1 = fib2;
            fib2 = temp;
        }

        return fib2;

    }
}
