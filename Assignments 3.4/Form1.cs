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
                RoastLevel = "Medium",
                HasMilk = true,
                HasSugar = false,
                IsDecaf = false,
                Type = CoffeeType.Latte
            });

            coffees.Add(new Coffee
            {
                Name = "Double Espresso",
                Price = 3.25m,
                RoastLevel = "Dark",
                HasMilk = false,
                HasSugar = true,
                IsDecaf = true,
                Type = CoffeeType.Espresso
            });

            dataGridView1.DataSource = coffees;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            typcbo.DataSource = Enum.GetValues(typeof(CoffeeType));

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            Coffee selected = (Coffee)dataGridView1.CurrentRow.DataBoundItem;
            coffees.Remove(selected);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter a valid price.");
                return;
            }

            Coffee c = new Coffee
            {
                Name = txtName.Text,
                Price = price,
                RoastLevel = txtRoastLevel.Text,
                HasMilk = chkHasMilk.Checked,
                HasSugar = chkHasSugar.Checked,
                IsDecaf = chkIsDecaf.Checked,
                Type = (CoffeeType)typcbo.SelectedItem
            };
            coffees.Add(c);

            txtName.Clear();
            txtPrice.Clear();
            txtRoastLevel.Clear();
            chkHasMilk.Checked = false;
            chkHasSugar.Checked = false;
            chkIsDecaf.Checked = false;
        }
    }
}