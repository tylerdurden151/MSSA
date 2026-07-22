using System.ComponentModel;

namespace Assignment_3._3._1;

public partial class Form1 : Form
{
    private BindingList<Student> students = new BindingList<Student>();
  
    public Form1()
    {
        InitializeComponent();

        students.Add(new Student { StudentId = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St", MonthOfAdmission = Month.January, Grade = 'A' });
        students.Add(new Student { StudentId = 2, FirstName = "Jane", LastName = "Smith", Address = "456 Elm St", MonthOfAdmission = Month.February, Grade = 'B' });
        students.Add(new Student { StudentId = 3, FirstName = "Bob", LastName = "Johnson", Address = "789 Oak St", MonthOfAdmission = Month.March, Grade = 'C' });

        dataGridView1.DataSource = students;
        dataGridView1.ReadOnly = true;
        dataGridView1.AllowUserToAddRows = false;
        cboMonth.DataSource = Enum.GetValues(typeof(Month));

    }

    /*
    private void AddStudent(Student student)
    {
        students.Add(student);
        PopulateDataGridView();
    }

    private void DeleteStudent(int studId)
    {
        var studentToRemove = student.FirstOrDefault(s => s.StudId == studId);
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            PopulateDataGridView();
        }
    }

    private void PopulateDataGridView()
    {
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = students;
    }
    */
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
