/*
 1. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data). 
Read the details from same file and print on console. 
 */
using System;
using System.IO;


        // Create a text file and write basic details to it.
        using (StreamWriter sw = new StreamWriter("Assignment2.3.1_text.txt"))
        {
            sw.WriteLine("Name: John Doe");
            sw.WriteLine("Age: 30");
            sw.WriteLine("Address: 123 Main St, Anytown, USA");
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
        } catch (Exception e) {
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }       
