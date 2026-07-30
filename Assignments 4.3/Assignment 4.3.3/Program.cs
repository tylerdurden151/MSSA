/*
3. Write a program in C# Sharp to print all unique elements in an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 5
element - 2 : 1
Expected Output :
The unique elements found in the array are :
5
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
        UniqueElements(arr);
    }

    public static void UniqueElements(int[] arr)
    {
        // Count occurrences of each element
        Dictionary<int, int> elementCount = new Dictionary<int, int>();
        foreach (var item in arr)
        {
            if (elementCount.ContainsKey(item))
            {
                elementCount[item]++;
            }
            else
            {
                elementCount[item] = 1;
            }
        }

        // Get elements that appear only once
        HashSet<int> uniqueElements = new HashSet<int>();
        foreach (var kvp in elementCount)
        {
            if (kvp.Value == 1)
            {
                uniqueElements.Add(kvp.Key);
            }
        }

        PrintUniqueElements(uniqueElements);

    }

    public static void PrintUniqueElements(HashSet<int> uniqueElements)
    {
        Console.WriteLine("The unique elements found in the array are :");
        if (uniqueElements.Count > 0)
        {
            foreach (var item in uniqueElements)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("No unique elements found.");
        }
    }
}
