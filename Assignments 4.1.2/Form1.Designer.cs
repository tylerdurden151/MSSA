namespace Assignments_4._1._2
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
            components = new System.ComponentModel.Container();
            addbtrn = new Button();
            Subtract = new Button();
            multibtn = new Button();
            divbtn = new Button();
            clrbtn = new Button();
            firstNbx = new TextBox();
            form1BindingSource = new BindingSource(components);
            secondNbx = new TextBox();
            resultbx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // addbtrn
            // 
            addbtrn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addbtrn.Location = new Point(869, 151);
            addbtrn.Name = "addbtrn";
            addbtrn.Size = new Size(146, 66);
            addbtrn.TabIndex = 0;
            addbtrn.Text = "ADD";
            addbtrn.UseVisualStyleBackColor = true;
            addbtrn.Click += addbtrn_Click;
            // 
            // Subtract
            // 
            Subtract.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Subtract.Location = new Point(1090, 151);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(146, 66);
            Subtract.TabIndex = 1;
            Subtract.Text = "SUBTRACT";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += Subtract_Click;
            // 
            // multibtn
            // 
            multibtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            multibtn.Location = new Point(869, 264);
            multibtn.Name = "multibtn";
            multibtn.Size = new Size(146, 66);
            multibtn.TabIndex = 2;
            multibtn.Text = "MULTIPLY";
            multibtn.UseVisualStyleBackColor = true;
            multibtn.Click += multibtn_Click;
            // 
            // divbtn
            // 
            divbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            divbtn.Location = new Point(1090, 264);
            divbtn.Name = "divbtn";
            divbtn.Size = new Size(146, 66);
            divbtn.TabIndex = 3;
            divbtn.Text = "DIVIDE";
            divbtn.UseVisualStyleBackColor = true;
            divbtn.Click += divbtn_Click;
            // 
            // clrbtn
            // 
            clrbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clrbtn.Location = new Point(956, 402);
            clrbtn.Name = "clrbtn";
            clrbtn.Size = new Size(178, 67);
            clrbtn.TabIndex = 4;
            clrbtn.Text = "CLEAR";
            clrbtn.UseVisualStyleBackColor = true;
            clrbtn.Click += clrbtn_Click;
            // 
            // firstNbx
            // 
            firstNbx.DataBindings.Add(new Binding("Text", form1BindingSource, "", true));
            firstNbx.Font = new Font("Segoe UI", 20F);
            firstNbx.Location = new Point(329, 151);
            firstNbx.Name = "firstNbx";
            firstNbx.Size = new Size(399, 78);
            firstNbx.TabIndex = 5;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // secondNbx
            // 
            secondNbx.Font = new Font("Segoe UI", 20F);
            secondNbx.Location = new Point(329, 325);
            secondNbx.Name = "secondNbx";
            secondNbx.Size = new Size(399, 78);
            secondNbx.TabIndex = 6;
            // 
            // resultbx
            // 
            resultbx.Font = new Font("Segoe UI", 20F);
            resultbx.Location = new Point(329, 501);
            resultbx.Name = "resultbx";
            resultbx.ReadOnly = true;
            resultbx.Size = new Size(392, 78);
            resultbx.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(382, 78);
            label1.Name = "label1";
            label1.Size = new Size(285, 54);
            label1.TabIndex = 8;
            label1.Text = "First Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(345, 268);
            label2.Name = "label2";
            label2.Size = new Size(339, 54);
            label2.TabIndex = 9;
            label2.Text = "Second Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(130, 518);
            label3.Name = "label3";
            label3.Size = new Size(150, 54);
            label3.TabIndex = 10;
            label3.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 766);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultbx);
            Controls.Add(secondNbx);
            Controls.Add(firstNbx);
            Controls.Add(clrbtn);
            Controls.Add(divbtn);
            Controls.Add(multibtn);
            Controls.Add(Subtract);
            Controls.Add(addbtrn);
            Name = "Form1";
            Text = "Calculator App";
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbtrn;
        private Button Subtract;
        private Button multibtn;
        private Button divbtn;
        private Button clrbtn;
        private TextBox firstNbx;
        private TextBox secondNbx;
        private TextBox resultbx;
        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource form1BindingSource;
    }
}
