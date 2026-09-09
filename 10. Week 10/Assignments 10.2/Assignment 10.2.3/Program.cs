/*
 * 3. Write a program in C# Sharp to find a string that starts and ends with a specific character.
Test Data :
The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
Input starting character for the string : A
Input ending character for the string : M
Expected Output :
The city starting with A and ending with M is : AMSTERDAM
 */

Solution result = new Solution();
string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
result.FindCity(cities, 'A', 'M');

public class Solution
{
    public void FindCity(string[] cities, char startChar, char endChar)
    {
        // LINQ query to find the city that starts with startChar and ends with endChar
        var cityQuery = from city in cities
                        where city.StartsWith(startChar.ToString(), StringComparison.OrdinalIgnoreCase) &&
                              city.EndsWith(endChar.ToString(), StringComparison.OrdinalIgnoreCase)
                        select city;
        // Display the filtered city
        foreach (var city in cityQuery)
        {
            Console.WriteLine($"The city starting with {startChar} and ending with {endChar} is : {city}");
        }
    }
}