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
            _people.Add(new Person
            {
                Name = "John",
                LastName = "Doe",
                Address = "123 Main St",
                MobileNumber = "123-456-7890",
                WorkNumber = "098-765-4321",
                HomeNumber = "555-555-5555"
            }); 

            _personBindingSource.DataSource = _people;
            dataGridView1.DataSource = _personBindingSource;


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