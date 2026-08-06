//Assignment #3
/* 3. Write a C# program to print the result of dividing two numbers. Print the quotient and remainder as well. Get the input from the user.*/
Console.WriteLine();
Console.WriteLine("Next Assignment!");

Console.WriteLine("Please enter a number: ");
double doubleNumber3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter another number: ");
double doubleNumber4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Here is the results of the dividing those two numbers:");
Console.WriteLine($"Quotient: {doubleNumber3 / doubleNumber4}");
Console.WriteLine($"Remainder : {doubleNumber3 % doubleNumber4}");