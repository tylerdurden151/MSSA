/*
 1. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). 
Read the details from same file and print on console. 
 */
using System;
using System.IO;


try
{
    // Create a text file and write basic details to it using user input.
    using (StreamWriter sw = new StreamWriter("Assignment2.3.1_text.txt"))
    {
        Console.Write("Name: ");
        sw.WriteLine("Name: " + Console.ReadLine());
        Console.Write("Age: ");
        sw.WriteLine("Age: " + Console.ReadLine());
        Console.Write("Address: ");
        sw.WriteLine("Address: " + Console.ReadLine());
    }
}
catch (Exception e)
{
    // Let the user know what went wrong.
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}
try
{
    // Read the details from the same file and print on console.
    using (StreamReader sr = new StreamReader("Assignment2.3.1_text.txt"))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
catch (Exception e)
{
    // Let the user know what went wrong.
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}
