namespace Assignments_3._4
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            addbtn = new Button();
            deletebtn = new Button();
            typcbo = new ComboBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            chkHasMilk = new CheckBox();
            chkHasSugar = new CheckBox();
            chkIsDecaf = new CheckBox();
            Namelbl = new Label();
            Pricelbl = new Label();
            roastlbl = new Label();
            typelbl = new Label();
            roastlvlcbo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1215, 233);
            dataGridView1.TabIndex = 0;
            // 
            // addbtn
            // 
            addbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addbtn.Location = new Point(56, 409);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(303, 53);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deletebtn.Location = new Point(462, 411);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(303, 51);
            deletebtn.TabIndex = 2;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // typcbo
            // 
            typcbo.FormattingEnabled = true;
            typcbo.Location = new Point(998, 295);
            typcbo.Name = "typcbo";
            typcbo.Size = new Size(217, 33);
            typcbo.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(34, 295);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 31);
            txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(294, 295);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(233, 31);
            txtPrice.TabIndex = 5;
            // 
            // chkHasMilk
            // 
            chkHasMilk.AutoSize = true;
            chkHasMilk.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkHasMilk.Location = new Point(815, 276);
            chkHasMilk.Name = "chkHasMilk";
            chkHasMilk.Size = new Size(120, 29);
            chkHasMilk.TabIndex = 7;
            chkHasMilk.Text = "Has Milk?";
            chkHasMilk.UseVisualStyleBackColor = true;
            // 
            // chkHasSugar
            // 
            chkHasSugar.AutoSize = true;
            chkHasSugar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkHasSugar.Location = new Point(815, 311);
            chkHasSugar.Name = "chkHasSugar";
            chkHasSugar.Size = new Size(132, 29);
            chkHasSugar.TabIndex = 8;
            chkHasSugar.Text = "Has Sugar?";
            chkHasSugar.UseVisualStyleBackColor = true;
            // 
            // chkIsDecaf
            // 
            chkIsDecaf.AutoSize = true;
            chkIsDecaf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkIsDecaf.Location = new Point(815, 346);
            chkIsDecaf.Name = "chkIsDecaf";
            chkIsDecaf.Size = new Size(115, 29);
            chkIsDecaf.TabIndex = 9;
            chkIsDecaf.Text = "Is Decaf?";
            chkIsDecaf.UseVisualStyleBackColor = true;
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Namelbl.Location = new Point(114, 267);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(62, 25);
            Namelbl.TabIndex = 10;
            Namelbl.Text = "Name";
            Namelbl.Click += label1_Click;
            // 
            // Pricelbl
            // 
            Pricelbl.AutoSize = true;
            Pricelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Pricelbl.Location = new Point(375, 267);
            Pricelbl.Name = "Pricelbl";
            Pricelbl.Size = new Size(54, 25);
            Pricelbl.TabIndex = 11;
            Pricelbl.Text = "Price";
            // 
            // roastlbl
            // 
            roastlbl.AutoSize = true;
            roastlbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            roastlbl.Location = new Point(606, 267);
            roastlbl.Name = "roastlbl";
            roastlbl.Size = new Size(104, 25);
            roastlbl.TabIndex = 12;
            roastlbl.Text = "RoastLevel";
            // 
            // typelbl
            // 
            typelbl.AutoSize = true;
            typelbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            typelbl.Location = new Point(1073, 267);
            typelbl.Name = "typelbl";
            typelbl.Size = new Size(53, 25);
            typelbl.TabIndex = 13;
            typelbl.Text = "Type";
            // 
            // roastlvlcbo
            // 
            roastlvlcbo.FormattingEnabled = true;
            roastlvlcbo.Location = new Point(560, 295);
            roastlvlcbo.Name = "roastlvlcbo";
            roastlvlcbo.Size = new Size(217, 33);
            roastlvlcbo.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 489);
            Controls.Add(roastlvlcbo);
            Controls.Add(typelbl);
            Controls.Add(roastlbl);
            Controls.Add(Pricelbl);
            Controls.Add(Namelbl);
            Controls.Add(chkIsDecaf);
            Controls.Add(chkHasSugar);
            Controls.Add(chkHasMilk);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(typcbo);
            Controls.Add(deletebtn);
            Controls.Add(addbtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addbtn;
        private Button deletebtn;
        private ComboBox typcbo;
        private TextBox txtName;
        private TextBox txtPrice;
        private CheckBox chkHasMilk;
        private CheckBox chkHasSugar;
        private CheckBox chkIsDecaf;
        private Label Namelbl;
        private Label Pricelbl;
        private Label roastlbl;
        private Label typelbl;
        private ComboBox roastlvlcbo;
    }
}
