using System.ComponentModel;
using System.Data;
using System.Xml.Linq;


namespace Assignments_3._4
{
    public partial class Form1 : Form
    {
        private BindingList<Coffee> coffees = new BindingList<Coffee>();
        public Form1()
        {
            InitializeComponent();
            coffees.Add(new Coffee
            {
                Name = "Vanilla Latte",
                Price = 4.50m,
                Level = RoastLevel.Medium,
                HasMilk = true,
                HasSugar = false,
                IsDecaf = false,
                Type = CoffeeType.Latte
            });

            coffees.Add(new Coffee
            {
                Name = "Double Espresso",
                Price = 3.25m,
                Level = RoastLevel.Dark,
                HasMilk = false,
                HasSugar = true,
                IsDecaf = true,
                Type = CoffeeType.Espresso
            });

            dataGridView1.DataSource = coffees;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            roastlvlcbo.DataSource =Enum.GetValues(typeof(RoastLevel));
            typcbo.DataSource = Enum.GetValues(typeof(CoffeeType));

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            if (dataGridView1.CurrentRow.DataBoundItem is not Coffee selected)
            {
                return;
            }

            coffees.Remove(selected);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter a valid price.");
                return;
            }

            if (roastlvlcbo.SelectedItem == null || typcbo.SelectedItem == null)
            {
                MessageBox.Show("Please select a roast level and coffee type.");
                return;
            }

            Coffee c = new Coffee
            {
                Name = txtName.Text,
                Price = price,
                Level = (RoastLevel)roastlvlcbo.SelectedItem,
                HasMilk = chkHasMilk.Checked,
                HasSugar = chkHasSugar.Checked,
                IsDecaf = chkIsDecaf.Checked,
                Type = (CoffeeType)typcbo.SelectedItem
            };
            coffees.Add(c);

            txtName.Clear();
            txtPrice.Clear();
            roastlvlcbo.SelectedIndex = -1;
            typcbo.SelectedIndex = -1;
            chkHasMilk.Checked = false;
            chkHasSugar.Checked = false;
            chkIsDecaf.Checked = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Coffee selected)
            {
                picCoffee.Image = null;
                return;
            }

            string path = $"Images\\{selected.Type}.png";

            if (File.Exists(path))
            {
                picCoffee.ImageLocation = path;
            }
            else
            {
                picCoffee.Image = null;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}