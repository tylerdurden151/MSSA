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
            LoadData();
            _personBindingSource.DataSource = _people;
            dataGridView1.DataSource = _personBindingSource;


        }

        private void LoadData()
        {
            // Add sample data to the list
            _people.Add(new Person { Name = "Alice", LastName = "Smith", Address = "456 Oak Ave", MobileNumber = "111-222-3333", WorkNumber = "444-555-6666", HomeNumber = "777-888-9999" });
            _people.Add(new Person { Name = "Bob", LastName = "Johnson", Address = "789 Pine St", MobileNumber = "222-333-4444", WorkNumber = "555-666-7777", HomeNumber = "888-999-0000" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new person and add it to the phone book
            Person newPerson = new Person
            {
                Name = firstNtxtbx.Text,
                LastName = lastNtxtbx.Text,
                Address = addtxtbx.Text,
                MobileNumber = mobileNtxtbox.Text,
                WorkNumber = workNtxtbx.Text,
                HomeNumber = homeNtxtbx.Text
            };
            _phoneBook.AddPerson(newPerson);
            _people.Add(newPerson);
            firstNtxtbx.Clear();
            lastNtxtbx.Clear();
            addtxtbx.Clear();
            mobileNtxtbox.Clear();
            workNtxtbx.Clear();
            homeNtxtbx.Clear();
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            if (dataGridView1.CurrentRow.DataBoundItem is not Person selected)
            {
                return;
            }
            //Pop up a confirmation dialog before deleting the selected person
            var confirm = MessageBox.Show(
            $"Delete {selected.Name} {selected.LastName}?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // If the user confirms, delete the person from the phone book and remove it from the BindingList
            if (confirm == DialogResult.Yes)
            {
                _phoneBook.DeletePerson($"{selected.Name} {selected.LastName}");
                _people.Remove(selected);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}