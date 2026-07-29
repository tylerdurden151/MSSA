using System.ComponentModel;
using System.Diagnostics;

namespace Assignments_4._2
{

    public partial class Form1 : Form
    {
        private BindingList<Student> _currentStudents;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;

            cboStudentSubject.DataSource = Enum.GetValues(typeof(Subject));
            cboStudentSubject.SelectedIndex = -1;

        }
        private void ShowStudentsForTeacher(Teacher teacher)
        {
            _currentStudents = new BindingList<Student>();

            foreach (Student s in DataSource.Students)
            {
                if (s.StudentSubject == teacher.TeacherSubject)
                {
                    _currentStudents.Add(s);
                }
            }

            dataGridView1.DataSource = _currentStudents;
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            using (LoginForm login = new LoginForm())
            {
                DialogResult result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dataGridView1.Enabled = true;
                    ShowStudentsForTeacher(Session.CurrentTeacher);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtStudentidbx.Text, out double id))
            {
                MessageBox.Show("Enter a valide id.");
                return;
            }

            if (cboStudentSubject.SelectedItem is not Subject)
            {
                MessageBox.Show("Please select a student subject.");
                return;
            }

            if (!double.TryParse(txtGPA.Text, out double grade))
            {
                MessageBox.Show("Enter a valid grade.");
                return;
            }
            if (grade < 0 || grade > 4)
            {
                MessageBox.Show("Enter a valid grade between 0 and 4.");
                return;
            }

            //add the student to the data source
            Student newStudent = new Student((int)id, txtStudentNamebx.Text, (Subject)cboStudentSubject.SelectedItem, grade);

            DataSource.Students.Add(newStudent);
            _currentStudents.Add(newStudent);
            //clear the text boxes
            txtStudentidbx.Clear();
            txtStudentNamebx.Clear();
            cboStudentSubject.SelectedIndex = -1;
            txtGPA.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add any initialization code here that should run when the form loads
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            if (dataGridView1.CurrentRow.DataBoundItem is not Student selected)
            {
                return;
            }

            DataSource.Students.Remove(selected);
            _currentStudents.Remove(selected);
        }

        private void topStudentGPAbtn_Click(object sender, EventArgs e)
        {
            if (_currentStudents == null || _currentStudents.Count == 0)
            {
                MessageBox.Show("No students available to evaluate.");
                return;
            }
            Student highest = _currentStudents[0];
            foreach (Student student in _currentStudents) {
                if (student.GPA > highest.GPA)
                {
                    highest = student;
                }
            }
            try
            {
                using (StreamWriter steam = new StreamWriter("top_students.txt"))
                {
                    steam.WriteLine("Top Student:");
                    steam.WriteLine($"ID: {highest.StudentId}");
                    steam.WriteLine($"Name: {highest.StudentName}");
                    steam.WriteLine($"Subject: {highest.StudentSubject}");
                    steam.WriteLine($"GPA: {highest.GPA}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            try
            {
                // Read the details from the same file and print on console.
                using (StreamReader sr = new StreamReader("top_students.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }

            MessageBox.Show("Saved highest GPA student to HighestGPA.txt");
           
        }
    }
}
