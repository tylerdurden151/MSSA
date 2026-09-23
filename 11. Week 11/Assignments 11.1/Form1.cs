using Microsoft.EntityFrameworkCore;

namespace Assignments_11._1

{
    public partial class MainForm : Form
    {
        private BookContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.LoadBooks();
        }

        protected void LoadBooks()
        {
            this.dbContext = new BookContext();
            this.dbContext.Database.EnsureCreated();
            this.dbContext.Books.Load();
            this.dataGridViewBooks.DataSource = this.dbContext.Books.Local.ToBindingList();
            
       
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.dataGridViewBooks.Refresh();
        }
    }
}
