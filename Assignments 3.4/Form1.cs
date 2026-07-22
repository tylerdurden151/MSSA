using System.ComponentModel;

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

        }
    }
}