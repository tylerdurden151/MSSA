/*
 3. Write a program in C# Sharp to create a function to input a string 
and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
 
 */


Console.WriteLine("Enter a string: ");
string? res = Console.ReadLine();
var result = SpacesInString(res);
Console.WriteLine($"{res} contains {result} spaces");

Console.WriteLine("Enter a string: ");
string? res2 = Console.ReadLine();
var result2 = CountSpaces(res2);
Console.WriteLine($"{res2} contains {result2} spaces");

int SpacesInString(string? value) { 
    
    char [] chars = value.ToCharArray();
    int count = 0;
    if (chars == null)
    {
        return 0;
    }

    foreach (char c in chars)
    {
        if (c == ' ')
        {
            count++;
        }
    }
   return count; 
}

//refactored and Streamlined code
int CountSpaces(string? value)
{
    return value?.Count(c => c == ' ') ?? 0;
}