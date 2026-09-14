using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq;

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
            this.LoadCars();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnFormClosing((FormClosingEventArgs)e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        // (R)ead - opens a fresh context and binds the grid to it.
        // Shared by OnLoad and the Refresh button so there is one place
        // that knows how to (re)connect to the database.
        private void LoadCars()
        {
            this.dbContext = new CarsContext();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.Cars.Load();

            this.dataGridViewCars.DataSource = this.dbContext.Cars.Local.ToBindingList();
        }

        // (C)reate - adds a new tracked Car. EF Core's ChangeTracker starts
        // watching it immediately; nothing hits the database until SaveChanges.
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            var car = new Car
            {
                Vin = string.Empty,
                Make = string.Empty,
                Model = string.Empty,
                Year = DateTime.Now.Year,
                Price = 0m
            };

            this.dbContext!.Cars.Add(car);

            // Local is the same ObservableCollection the grid is bound to,
            // so the new row appears without us touching the grid directly.
            this.dataGridViewCars.ClearSelection();
            var newRowIndex = this.dataGridViewCars.Rows.Count - 1;
            if (newRowIndex >= 0)
            {
                this.dataGridViewCars.CurrentCell = this.dataGridViewCars.Rows[newRowIndex].Cells[1];
                this.dataGridViewCars.BeginEdit(true);
            }
        }

        // (D)elete - explicit button version of the same thing UserDeletingRow
        // does, but works for a multi-row selection instead of one row at a time.
        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            // ToList() copies the selection out first - removing rows from a
            // collection while you are still enumerating it throws
            // InvalidOperationException ("Collection was modified").
            var carsToRemove = this.dataGridViewCars.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(row => row.DataBoundItem)
                .OfType<Car>()
                .ToList();

            if (carsToRemove.Count == 0)
            {
                MessageBox.Show(
                    "Select one or more rows first.",
                    "No rows selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            this.dbContext!.Cars.RemoveRange(carsToRemove);
        }

        private void dataGridViewCars_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is Car car)
            {
                this.dbContext?.Cars.Remove(car);
            }
        }

        // Cancel - throws away every pending Add/Update/Remove and reloads
        // the grid straight from the database.
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "This discards any unsaved changes and reloads from the database. Continue?",
                "Refresh",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            this.dbContext?.Dispose();
            this.LoadCars();
        }

        // (U)pdate - cell edits in the grid already flow into tracked Car
        // instances. Save just needs to call SaveChanges once.
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.dataGridViewCars.Refresh();
        }
    }
}
