/*2. Divisible by 2 or 3

Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum.

Expected input and output

DivisibleBy2Or3(15, 30) → 450 DivisibleBy2Or3(2, 90) → 180 DivisibleBy2Or3(7, 12) → 19
 
 */
int result = Solution(15, 30);
int result2 = Solution(15, 31);
int result3 = Solution(15, 30);

Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);



static int Solution(int a, int b)
{
    if ((a % 2 == 0 && b % 2 == 0) || (a % 3 == 0 && b % 3 == 0))
    {
        return a * b;
    }
    else
    {
        return a + b;
    }
}
