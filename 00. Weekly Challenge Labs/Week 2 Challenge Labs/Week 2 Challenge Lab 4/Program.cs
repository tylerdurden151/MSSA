/*
 4. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. 
(May use a struct / class to represent the student)
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
*/

Student s = new Student();
s.Run();

public class Student
{
    private int _id;
    private string? _name;
    private int _physics;
    private int _chemistry;
    private int _computerApplication;

    public int Id { get { return _id; } set { _id = value; } }
    public string? Name { get { return _name; } set { _name = value; } }
    public int Physics { get { return _physics; } set { _physics = value; } }
    public int Chemistry { get { return _chemistry; } set { _chemistry = value; } }
    public int ComputerApplication { get { return _computerApplication; } set { _computerApplication = value; } }

    public void Run()
    {
        Console.WriteLine("Input the Roll Number of the student :");
        Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the Name of the Student :");
        Name = Console.ReadLine();
        Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application :");
        string[] marks = Console.ReadLine().Split(' ');
        Physics = Convert.ToInt32(marks[0]);
        Chemistry = Convert.ToInt32(marks[1]);
        ComputerApplication = Convert.ToInt32(marks[2]);
        Calculate();
    }

    public void Calculate()
    {
        int total = Physics + Chemistry + ComputerApplication;
        double percentage = (double)total / 3;
        string division;

        switch (percentage)
        {
            case >= 60:
                division = "First";
                break;
            case >= 50:
                division = "Second";
                break;
            case >= 40:
                division = "Third";
                break;
            default:
                division = "Fail";
                break;
        }  
        Display(total, percentage, division);
    }

    public void Display(int total, double percentage, string division)
    {
        Console.WriteLine($"Roll No : {Id}");
        Console.WriteLine($"Name of Student : {Name}");
        Console.WriteLine($"Marks in Physics : {Physics}");
        Console.WriteLine($"Marks in Chemistry : {Chemistry}");
        Console.WriteLine($"Marks in Computer Application : {ComputerApplication}");
        Console.WriteLine($"Total Marks = {total}");
        Console.WriteLine($"Percentage = {percentage:F2}");
        Console.WriteLine($"Division = {division}");
    }

}