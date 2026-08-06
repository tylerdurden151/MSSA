namespace Assignments_4._2
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
            signinbtn = new Button();
            dataGridView1 = new DataGridView();
            txtStudentidbx = new TextBox();
            txtStudentNamebx = new TextBox();
            txtGPA = new TextBox();
            cboStudentSubject = new ComboBox();
            addbtn = new Button();
            deletebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            topStudentGPAbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // signinbtn
            // 
            signinbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            signinbtn.Location = new Point(35, 648);
            signinbtn.Name = "signinbtn";
            signinbtn.Size = new Size(302, 54);
            signinbtn.TabIndex = 0;
            signinbtn.Text = "Sign In";
            signinbtn.UseVisualStyleBackColor = true;
            signinbtn.Click += signinbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1423, 334);
            dataGridView1.TabIndex = 1;
            // 
            // txtStudentidbx
            // 
            txtStudentidbx.Location = new Point(136, 426);
            txtStudentidbx.Name = "txtStudentidbx";
            txtStudentidbx.Size = new Size(143, 39);
            txtStudentidbx.TabIndex = 2;
            // 
            // txtStudentNamebx
            // 
            txtStudentNamebx.Location = new Point(344, 426);
            txtStudentNamebx.Name = "txtStudentNamebx";
            txtStudentNamebx.Size = new Size(386, 39);
            txtStudentNamebx.TabIndex = 3;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(1199, 426);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(235, 39);
            txtGPA.TabIndex = 5;
            txtGPA.TextChanged += textBox4_TextChanged;
            // 
            // cboStudentSubject
            // 
            cboStudentSubject.FormattingEnabled = true;
            cboStudentSubject.Location = new Point(850, 426);
            cboStudentSubject.Name = "cboStudentSubject";
            cboStudentSubject.Size = new Size(242, 40);
            cboStudentSubject.TabIndex = 6;
            // 
            // addbtn
            // 
            addbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addbtn.Location = new Point(431, 511);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(219, 47);
            addbtn.TabIndex = 7;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deletebtn.Location = new Point(863, 511);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(219, 47);
            deletebtn.TabIndex = 8;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(105, 379);
            label1.Name = "label1";
            label1.Size = new Size(217, 32);
            label1.TabIndex = 9;
            label1.Text = "Type Student ID #";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(394, 379);
            label2.Name = "label2";
            label2.Size = new Size(395, 32);
            label2.TabIndex = 10;
            label2.Text = "Type Student First and Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(835, 379);
            label3.Name = "label3";
            label3.Size = new Size(257, 32);
            label3.TabIndex = 11;
            label3.Text = "Select Student's Class";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label4.Location = new Point(1199, 379);
            label4.Name = "label4";
            label4.Size = new Size(218, 32);
            label4.TabIndex = 12;
            label4.Text = "Type Student GPA";
            // 
            // topStudentGPAbtn
            // 
            topStudentGPAbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            topStudentGPAbtn.Location = new Point(1181, 511);
            topStudentGPAbtn.Name = "topStudentGPAbtn";
            topStudentGPAbtn.Size = new Size(287, 46);
            topStudentGPAbtn.TabIndex = 13;
            topStudentGPAbtn.Text = "Print Top Students";
            topStudentGPAbtn.UseVisualStyleBackColor = true;
            topStudentGPAbtn.Click += topStudentGPAbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 722);
            Controls.Add(topStudentGPAbtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deletebtn);
            Controls.Add(addbtn);
            Controls.Add(cboStudentSubject);
            Controls.Add(txtGPA);
            Controls.Add(txtStudentNamebx);
            Controls.Add(txtStudentidbx);
            Controls.Add(dataGridView1);
            Controls.Add(signinbtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signinbtn;
        private DataGridView dataGridView1;
        private TextBox txtStudentidbx;
        private TextBox txtStudentNamebx;
        private TextBox txtGPA;
        private ComboBox cboStudentSubject;
        private Button addbtn;
        private Button deletebtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button topStudentGPAbtn;
    }
}
