using System.ComponentModel;

namespace Assignment_4._1
{
    public partial class Form1 : Form
    {
        private PhoneBook _phoneBook = new PhoneBook();
        private BindingSource _personBindingSource = new BindingSource();
        private BindingList<Person> _people;
        public Form1()
        {

            InitializeComponent();
            _people = new BindingList<Person>();
            _personBindingSource.DataSource = _people;
            dataGridView1.DataSource = _personBindingSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new person and add it to the phone book
            Person newPerson = new Person
            {
                Name = "John",
                LastName = "Doe",
                Address = "123 Main St",
                MobileNumber = "555-1234",
                WorkNumber = "555-5678",
                HomeNumber = "555-8765"
            };
            _phoneBook.AddPerson(newPerson);
            UpdateDataGridView();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;   // or however you're capturing which person

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a name to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete {name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool removed = _phoneBook.DeletePerson(name);

                if (removed)
                    RefreshGrid();          // or _people.Remove(...) if using BindingList
                else
                    MessageBox.Show("No person found with that name.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}