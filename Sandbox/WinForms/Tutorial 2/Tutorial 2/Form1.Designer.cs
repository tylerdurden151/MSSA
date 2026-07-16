namespace Tutorial_2
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
            timeLabel = new Label();
            label1 = new Label();
            pluseLeftLabel = new Label();
            plusRightLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(257, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(99, -6);
            label1.Name = "label1";
            label1.Size = new Size(152, 45);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // pluseLeftLabel
            // 
            pluseLeftLabel.Font = new Font("Segoe UI", 18F);
            pluseLeftLabel.Location = new Point(50, 75);
            pluseLeftLabel.Name = "pluseLeftLabel";
            pluseLeftLabel.Size = new Size(60, 50);
            pluseLeftLabel.TabIndex = 2;
            pluseLeftLabel.Text = "?";
            pluseLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(182, 75);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(116, 75);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 4;
            label3.Text = "+";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(248, 75);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(180, 274);
            sum.MaximumSize = new Size(100, 0);
            sum.Name = "sum";
            sum.Size = new Size(100, 55);
            sum.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 344);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(pluseLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label pluseLeftLabel;
        private Label plusRightLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown sum;
    }
}
