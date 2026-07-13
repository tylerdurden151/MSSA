//Assignment #1
/* 1. Create a console application in C# to store and print personal details of a person like name, age and address on console screen. Make use of appropriate variables.*/

Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();


Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please enter your address: ");
string address = Console.ReadLine();

Console.WriteLine($"Hello, {name}! You are {age} years old. And I live {address}");
