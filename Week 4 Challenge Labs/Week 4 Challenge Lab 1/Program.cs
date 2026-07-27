/*
 * 1. If number contains 3

Write a method that checks if given number (positive integer) contains digit 3. 
Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.

Expected input and output

IfNumberContains3(7201432) → true IfNumberContains3(87501) → false
 */
bool result = IfNumberContains3(7201432);
bool result2 = IfNumberContains3(87501);

Console.WriteLine(result);
Console.WriteLine(result2);

static bool IfNumberContains3(int number)
{
    // Check if the number is positive
    if (number < 0)
    {
        throw new ArgumentException("Number must be a positive integer.");
    }
    // Loop through each digit of the number
    while (number > 0)
    {
        // Get the last digit
        int digit = number % 10;
        // Check if the digit is 3
        if (digit == 3)
        {
            return true;
        }
        // Remove the last digit from the number
        number /= 10;
    }
    // If no digit 3 was found, return false
    return false;
}
