namespace Assignments_11._3
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            genreBindingSource = new BindingSource();
            genreBindingSource.DataSource = typeof(Genre);
            dataGridViewGenre = new DataGridView();
            dataGridViewMovies = new DataGridView();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGenre
            // 
            dataGridViewGenre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenre.DataSource = genreBindingSource;
            dataGridViewGenre.Location = new Point(87, 52);
            dataGridViewGenre.Name = "dataGridViewGenre";
            dataGridViewGenre.RowHeadersWidth = 82;
            dataGridViewGenre.Size = new Size(1047, 387);
            dataGridViewGenre.TabIndex = 0;
            dataGridViewGenre.SelectionChanged += dataGridViewGenre_SelectionChanged;
            //
            // dataGridViewMovies
            //
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.DataSource = genreBindingSource;
            dataGridViewMovies.DataMember = "Movies";
            dataGridViewMovies.Location = new Point(1230, 52);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 82;
            dataGridViewMovies.Size = new Size(1026, 384);
            dataGridViewMovies.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(2025, 487);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(228, 54);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2613, 609);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewMovies);
            Controls.Add(dataGridViewGenre);
            Name = "Mainform";
            Text = "Movie and Genre";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource genreBindingSource;
        private DataGridView dataGridViewGenre;
        private DataGridView dataGridViewMovies;
        private Button buttonSave;
    }
}
