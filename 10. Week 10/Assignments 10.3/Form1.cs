using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Assignment_10._3
{
    public partial class MainForm : Form
    {
        private CarsContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new CarsContext();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.Cars.Load();

            this.dataGridViewCars.DataSource = this.dbContext.Cars.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnFormClosing((FormClosingEventArgs)e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewCars_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is Car car)
            {
                this.dbContext?.Cars.Remove(car);
            }
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.dataGridViewCars.Refresh();
        }
    }
}
