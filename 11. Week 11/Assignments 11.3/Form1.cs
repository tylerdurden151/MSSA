using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Assignments_11._3
{
    public partial class Mainform : Form
    {
        private MovieContext? dbContext;
        public Mainform()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dbContext = new MovieContext();
            dbContext.Database.EnsureCreated();

            dbContext.Genres.Load();
            genreBindingSource.DataSource = dbContext.Genres.Local.ToBindingList();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            dbContext?.Dispose();
            dbContext = null;
        }
        private void dataGridViewGenre_SelectionChanged(object sender, EventArgs e)
        {
            if (dbContext is null) return;

            var genre = (Genre)dataGridViewGenre.CurrentRow.DataBoundItem;
            if (genre != null)
                dbContext.Entry(genre).Collection(g => g.Movies).Load();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            dbContext!.SaveChanges();
            dataGridViewGenre.Refresh();
            dataGridViewMovies.Refresh();
        }
    }
}
