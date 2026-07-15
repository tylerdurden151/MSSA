/*
 1. Write a program in C# Sharp to find the sum of all array elements.

Test Data :

Input the number of elements to be stored in the array :3

Input 3 elements in the array :

element - 0 : 2

element - 1 : 5

element - 2 : 8

Expected Output :

Sum of all elements stored in the array is : 15
 */

Console.WriteLine("How long would you like your Array to be?");
int arrLength = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arrLength];
int sum = 0;
Console.WriteLine($"Please input {arrLength} numbers for the Array.");
numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

foreach (int i in numbers)
{
    sum += i;

}
Console.WriteLine("The sum of the numbers in the Array is: " + sum);
