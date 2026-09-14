namespace Assignment_10._3
{
    partial class MainForm
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
            buttonSave = new Button();
            dataGridViewCars = new DataGridView();
            buttonAddCar = new Button();
            buttonDeleteCar = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1199, 368);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 46);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(60, 46);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 82;
            dataGridViewCars.Size = new Size(1865, 300);
            dataGridViewCars.TabIndex = 4;
            dataGridViewCars.UserDeletingRow += dataGridViewCars_UserDeletingRow;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(743, 368);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(120, 46);
            buttonAddCar.TabIndex = 1;
            buttonAddCar.Text = "Add Car";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonDeleteCar
            // 
            buttonDeleteCar.Location = new Point(893, 368);
            buttonDeleteCar.Name = "buttonDeleteCar";
            buttonDeleteCar.Size = new Size(120, 46);
            buttonDeleteCar.TabIndex = 2;
            buttonDeleteCar.Text = "Delete selected";
            buttonDeleteCar.UseVisualStyleBackColor = true;
            buttonDeleteCar.Click += buttonDeleteCar_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(1042, 368);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(140, 46);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh ";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2062, 475);
            Controls.Add(dataGridViewCars);
            Controls.Add(buttonAddCar);
            Controls.Add(buttonDeleteCar);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonSave);
            Name = "MainForm";
            Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private DataGridView dataGridViewCars;
        private Button buttonAddCar;
        private Button buttonDeleteCar;
        private Button buttonRefresh;
    }
}
