namespace Assignments_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Enabled = false;
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            using (LoginForm login = new LoginForm())
            {
                DialogResult result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dataGridView1.Enabled = true;
                    lblWelcome.Text = $"Welcome, {Session.CurrentTeacher.UserName}";
                    ShowStudentsForTeacher(Session.CurrentTeacher);
                }
            }
        }
    }
}
