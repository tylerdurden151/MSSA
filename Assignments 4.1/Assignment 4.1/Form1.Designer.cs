namespace Assignment_4._1
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
            dltbtn = new Button();
            firstNtxtbx = new TextBox();
            lastNtxtbx = new TextBox();
            addtxtbx = new TextBox();
            mobileNtxtbox = new TextBox();
            workNtxtbx = new TextBox();
            homeNtxtbx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            searchbtn = new Button();
            searchbx = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1439, 184);
            dataGridView1.TabIndex = 0;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(158, 436);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(173, 39);
            addbtn.TabIndex = 1;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button1_Click;
            // 
            // dltbtn
            // 
            dltbtn.Location = new Point(1153, 445);
            dltbtn.Name = "dltbtn";
            dltbtn.Size = new Size(173, 39);
            dltbtn.TabIndex = 2;
            dltbtn.Text = "Delete";
            dltbtn.UseVisualStyleBackColor = true;
            dltbtn.Click += dltbtn_Click;
            // 
            // firstNtxtbx
            // 
            firstNtxtbx.Location = new Point(219, 244);
            firstNtxtbx.Name = "firstNtxtbx";
            firstNtxtbx.Size = new Size(200, 39);
            firstNtxtbx.TabIndex = 3;
            // 
            // lastNtxtbx
            // 
            lastNtxtbx.Location = new Point(585, 244);
            lastNtxtbx.Name = "lastNtxtbx";
            lastNtxtbx.Size = new Size(200, 39);
            lastNtxtbx.TabIndex = 4;
            // 
            // addtxtbx
            // 
            addtxtbx.Location = new Point(906, 244);
            addtxtbx.Name = "addtxtbx";
            addtxtbx.Size = new Size(476, 39);
            addtxtbx.TabIndex = 5;
            // 
            // mobileNtxtbox
            // 
            mobileNtxtbox.Location = new Point(198, 340);
            mobileNtxtbox.Name = "mobileNtxtbox";
            mobileNtxtbox.Size = new Size(232, 39);
            mobileNtxtbox.TabIndex = 6;
            // 
            // workNtxtbx
            // 
            workNtxtbx.Location = new Point(603, 340);
            workNtxtbx.Name = "workNtxtbx";
            workNtxtbx.Size = new Size(232, 39);
            workNtxtbx.TabIndex = 7;
            // 
            // homeNtxtbx
            // 
            homeNtxtbx.Location = new Point(1021, 340);
            homeNtxtbx.Name = "homeNtxtbx";
            homeNtxtbx.Size = new Size(232, 39);
            homeNtxtbx.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 209);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 9;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 209);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 10;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(956, 209);
            label3.Name = "label3";
            label3.Size = new Size(399, 32);
            label3.TabIndex = 11;
            label3.Text = "Address: Street, City, State, Zip Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 305);
            label4.Name = "label4";
            label4.Size = new Size(184, 32);
            label4.TabIndex = 12;
            label4.Text = "Mobile Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 305);
            label5.Name = "label5";
            label5.Size = new Size(164, 32);
            label5.TabIndex = 13;
            label5.Text = "Work Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1048, 305);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 14;
            label6.Text = "Home Number";
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(553, 681);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(150, 46);
            searchbtn.TabIndex = 15;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchbx
            // 
            searchbx.Location = new Point(487, 582);
            searchbx.Name = "searchbx";
            searchbx.Size = new Size(313, 39);
            searchbx.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(462, 538);
            label8.Name = "label8";
            label8.Size = new Size(373, 32);
            label8.TabIndex = 18;
            label8.Text = "Search First Name and Last Name";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1592, 785);
            Controls.Add(label8);
            Controls.Add(searchbx);
            Controls.Add(searchbtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(homeNtxtbx);
            Controls.Add(workNtxtbx);
            Controls.Add(mobileNtxtbox);
            Controls.Add(addtxtbx);
            Controls.Add(lastNtxtbx);
            Controls.Add(firstNtxtbx);
            Controls.Add(dltbtn);
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
        private Button dltbtn;
        private TextBox firstNtxtbx;
        private TextBox lastNtxtbx;
        private TextBox addtxtbx;
        private TextBox mobileNtxtbox;
        private TextBox workNtxtbx;
        private TextBox homeNtxtbx;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button searchbtn;
        private TextBox searchbx;
        private Label label8;
    }
}
