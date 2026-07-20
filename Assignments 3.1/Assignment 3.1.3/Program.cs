/*
 3. Write a program in C# Sharp to create a function to input a string 
and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
 
 */

using System.Text;


var result = SpacesInString("This is a test string.");
Console.WriteLine(result);

int SpacesInString(string value) { 
    
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