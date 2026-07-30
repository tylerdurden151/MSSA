/*
 2. Write a program in C# Sharp to count the frequency of each element of an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 25
element - 1 : 12
element - 2 : 43
Expected Output :
Frequency of all elements of array :
25 occurs 1 times
12 occurs 1 times
43 occurs 1 times
*/

Solution.Run();

public class Solution
{
    public static void Run()
    {
        Console.WriteLine("Enter the number of elements to be stored in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine($"Input {n} elements in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        CountFrequency(arr);

    }
    public static void CountFrequency(int[] arr)
    {
        Console.WriteLine("Frequency of all elements of array:");
        var frequencyDict = new Dictionary<int, int>();
        foreach (var item in arr)
        {
            if (frequencyDict.ContainsKey(item))
            {
                frequencyDict[item]++;
            }
            else
            {
                frequencyDict[item] = 1;
            }
        }
        PrintFrequency(frequencyDict);
    }
    public static void PrintFrequency(Dictionary<int, int> frequencyDict)
    {
        foreach (var kvp in frequencyDict)
        {
            Console.WriteLine($"{kvp.Key} occurs {kvp.Value} times");
        }
    }
}
