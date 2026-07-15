/*
 2. Write a C# Sharp program to find the largest of three numbers.

Test Data :

Input the 1st number :25

Input the 2nd number :63

Input the 3rd number :10

Expected Output :

The 2nd Number is the greatest among three
 */

Console.WriteLine("Please input the first number.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input the second number.");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input the third number.");
int num3 = Convert.ToInt32(Console.ReadLine());

int currentLargest = num1;
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        currentLargest = num1;
    }
    else if (i == 1)
    {
        if (num2 > currentLargest)
        {
            currentLargest = num2;
        }
    }
    else if (i == 2)
    {
        if (num3 > currentLargest)
        {
            currentLargest = num3;
        }
    }
}
Console.WriteLine($"The largest number is: {currentLargest}");
