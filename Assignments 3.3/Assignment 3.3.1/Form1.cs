using System.ComponentModel;

namespace Assignment_3._3._1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        List<Student> students = new List<Student>();
        students.Add(new Student { StudentId = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", MonthOfAdmission = Month.January, Grade = 'A' });
        students.Add(new Student { StudentId = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Elm St", MonthOfAdmission = Month.February, Grade = 'B' });
        students.Add(new Student { StudentId = 3, FirstName = "Bob", LastName = "Johnson", Address = "789 Oak St", MonthOfAdmission = Month.March, Grade = 'C' });

        var list = new BindingList<Student>(students);
      //  dataGridView1.DataSource = list;
        
    }


}
