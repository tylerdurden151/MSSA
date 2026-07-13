/*Write a console application in C# to explore different ways in which array is declared
 * and initialized and explore different properties and methods of Array class.
 */

using System.Collections;

Console.WriteLine("Welcome to the Assignment 1.3.2");
Console.WriteLine("Declared array");
int[] arr = new int[3];
arr[0] = 10;
arr[1] = 20;
arr[2] = 30;
foreach (int i in arr)
{
    Console.WriteLine(i);
}

Console.WriteLine();
Console.WriteLine("///////////////////////////////////");
int x = arr[2];
Console.WriteLine("The value of the third element is: " + x);
Console.WriteLine();
Console.WriteLine("///////////////////////////////////");

// Part 2

int[] arr2 = { 10, 20, 30 };
int upper = arr2.GetUpperBound(0);
Console.WriteLine("Upper bound of the array is: " + upper);

Console.WriteLine();
Console.WriteLine("///////////////////////////////////");

Console.WriteLine("Find method, used to find exact value");
int value_3 = Array.Find(arr2, n => n == arr2[2]); // Used n => n to shorthand function
Console.WriteLine(value_3);

Console.WriteLine();
Console.WriteLine("///////////////////////////////////");
Console.WriteLine("Sorting the array");

Array.Sort(arr2);
Array.ForEach(arr2, Console.WriteLine);