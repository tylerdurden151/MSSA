/*Write a program in C# to read n number of values in an array and display it in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2 
 */

Console.WriteLine("Welcome to Assignement 1.3.3");
Console.WriteLine("Please enter values into the array, separated by spaces:");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
ArrayReverse(numbers);
static void ArrayReverse(int[] arr)
{
    int left = 0;
    int right = arr.Length - 1;
    while (left < right)
    {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        left++;
        right--;
    }
    Console.WriteLine("Reversed array: " + string.Join(" ", arr));
}