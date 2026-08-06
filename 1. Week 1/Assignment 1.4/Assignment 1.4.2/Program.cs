/*Write a class: “Student” with private data members: StudentId ( int), StudentFname (string), StudentLname (string ), StudentGrade ( char ) and public properties for each data member. 
 * Instantiate the class and assign data to properties. Display the data back on console.
 */
using System;

Student student1 = new Student();
Student student2 = new Student(2, "John", "Guy", 'B');
student1.StudentName = "Test";
student1.StudentLname = "User";
student1.StudentId = 1;
student1.StudentGrade = 'A';
student1.DisplayInfo();
student2.DisplayInfo();


public class Student
{
    private int studentId;
    private string name = string.Empty;
    private string lname = string.Empty;
    private char grade;

    public int StudentId { get { return studentId; } set { studentId = value; } }
    public string StudentName { get { return name; } set { name = value; } }
    public string StudentLname { get { return lname; } set { lname = value; } }
    public char StudentGrade { get { return grade; } set { grade = value; } }

    // parameterless constructor
    public Student() { }

    // parameterized constructor assigns to properties
    public Student(int studentId, string studentName, string studentLname, char studentGrade)
    {
        this.StudentId = studentId;
        this.StudentName = studentName;
        this.StudentLname = studentLname;
        this.StudentGrade = studentGrade;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {StudentName} {StudentLname}, ID: {StudentId}, Grade: {StudentGrade}");
    }
}
